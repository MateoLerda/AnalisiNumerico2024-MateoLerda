using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Cuatro
{
	internal class Logica4
	{
		public Resultado4 CalculoArea(Datos datos)
		{
			Resultado4 result = new Resultado4();
			switch (datos.Metodo)
			{
				case 0:
					result = trapecioSimple(datos);
					break;
				case 1:
					result = tarpecioMultiple(datos);
					break;
				case 2:
					result= simpson13Simple(datos);
					break;
				case 3:
					result= simpson13Multiple(datos);
					break;
				case 4:
					result= simpson38(datos);
					break;
				case 5:
					result = simpsonConvinado(datos);
					break;
				default:
					result.Sucsses = false;
					result.Message = "Metodo incorrecto";
					break;
			}
			result.Area = Math.Round(result.Area, 5);
			return result;
		}
		// 0
		private Resultado4 trapecioSimple(Datos datos)
		{
			Resultado4 resultado = new Resultado4();
			Calculo funcion = new Calculo();
			if (funcion.Sintaxis(datos.Funcion, 'x'))
			{
				resultado.Area= ((funcion.EvaluaFx(datos.Xi) + funcion.EvaluaFx(datos.Xd)) * (datos.Xd - datos.Xi)) / 2;
				resultado.Sucsses= true;
			}
			else
			{
				resultado.Message = "Funcion ingresada incorrectamente";
			}
			return resultado;
		}
		//1
		private Resultado4 tarpecioMultiple(Datos datos){ 
			Calculo funcion= new Calculo();
			Resultado4 resultado= new Resultado4();
			if (funcion.Sintaxis(datos.Funcion, 'x')) {
				double h = (datos.Xd - datos.Xi) / datos.CantidadSubInter;
				double sum = 0;
                for (int i = 1;  i < datos.CantidadSubInter; i++)
                {
					sum += funcion.EvaluaFx(datos.Xi + h * i);
                }
				resultado.Area = (h / 2) * (funcion.EvaluaFx(datos.Xi) + 2 * sum + funcion.EvaluaFx(datos.Xd));
				resultado.Sucsses = true;
            }
			else
			{
				resultado.Message= "Metodo incorrecto";
			}
			return resultado;
		}
		//2
		private Resultado4 simpson13Simple(Datos datos) {
			Calculo funcion = new Calculo();
			Resultado4 resultado = new Resultado4();
			if (funcion.Sintaxis(datos.Funcion, 'x'))
			{
				double h = (datos.Xd - datos.Xi) / 2;
				resultado.Area = (h / 3) * (funcion.EvaluaFx(datos.Xi) + 4 * funcion.EvaluaFx(datos.Xi + h) + funcion.EvaluaFx(datos.Xd));
				resultado.Sucsses = true;
			}
			else
			{
				resultado.Message = "Metodo incorrecto";
			}
			return resultado;
		}
		//3
		private Resultado4 simpson13Multiple(Datos datos)
		{
			Resultado4 resultado = new Resultado4();
			if (datos.CantidadSubInter % 2 != 0) {
				resultado.Message = "Los sb intervalos en el metodo simpson 1/3 Multiple deben ser pares";
				return resultado;
			}
			Calculo funcion = new Calculo();
			if (funcion.Sintaxis(datos.Funcion, 'x'))
			{
				double h = (datos.Xd - datos.Xi) / datos.CantidadSubInter;
				double sum = funcion.EvaluaFx(datos.Xi)+funcion.EvaluaFx(datos.Xd);
				
				for (int i = 1; i < datos.CantidadSubInter; i++) {
					double x_i= datos.Xi + i*h;
					if (i % 2 == 0) {
						sum += 2*funcion.EvaluaFx(x_i);
					}
					else
					{
						sum += 4*funcion.EvaluaFx(x_i);
					}
				}
				resultado.Area = (h / 3) * sum;
				resultado.Sucsses= true;
			}
			else
			{
				resultado.Message = "Metodo incorrecto";
			}
			return resultado;
		}
		//4 
		private Resultado4 simpson38(Datos datos)
		{
			Calculo funcion = new Calculo();
			Resultado4 resultado = new Resultado4();
			if (funcion.Sintaxis(datos.Funcion, 'x'))
			{
				double h = (datos.Xd - datos.Xi) / 3;
				double f0 = funcion.EvaluaFx(datos.Xi);
				double f1 = funcion.EvaluaFx(datos.Xi + h);
				double f2 = funcion.EvaluaFx(datos.Xi + (h * 2));
				double f3 = funcion.EvaluaFx(datos.Xd);
				resultado.Area = (3 * (h / 8)) * (f0 + 3 * f1 + 3 * f2 + f3);
				resultado.Sucsses = true;
			}
			else
			{
				resultado.Message = "Metodo incorrecto";
			}
			return resultado;
		}
		//5
		private Resultado4 simpsonConvinado(Datos datos)
		{
			Calculo funcion = new Calculo();
			Resultado4 resultado = new Resultado4();
			if (funcion.Sintaxis(datos.Funcion, 'x'))
			{
				int n = datos.CantidadSubInter;
				double h = (datos.Xd - datos.Xi) / n;
				double area  = 0;

				if (n >= 3 && (n % 3 == 0))
				{
					
					double x0 = datos.Xi + (n - 3) * h;
					double x1 = x0 + h;
					double x2 = x0 + 2 * h;
					double x3 = x0 + 3 * h;

					double f0 = funcion.EvaluaFx(x0);
					double f1 = funcion.EvaluaFx(x1);
					double f2 = funcion.EvaluaFx(x2);
					double f3 = funcion.EvaluaFx(x3);

					area += (3 * h / 8) * (f0 + 3 * f1 + 3 * f2 + f3);
					n -= 3; 
				}

				
				if (n % 2 == 0)
				{
					
					double xi = datos.Xi;
					double xf = datos.Xi + n * h;

					double f0 = funcion.EvaluaFx(xi);
					double fn = funcion.EvaluaFx(xf);
					double sumImpares = 0, sumPares = 0;

					
					for (int i = 1; i < n; i++)
					{
						double x = xi + i * h;
						double fx = funcion.EvaluaFx(x);

						if (i % 2 == 0)
							sumPares += fx;
						else
							sumImpares += fx;
					}

					area += (h / 3) * (f0 + 4 * sumImpares + 2 * sumPares + fn);
				}
				else
				{
					resultado.Message = "Número de subintervalos inválido para Simpson Combinado.";
					return resultado;
				}

				resultado.Area = area;
				resultado.Sucsses = true;

			}
			else
			{
				resultado.Message = "Metodo incorrecto";
			}
			return resultado;
		}
	}
}
