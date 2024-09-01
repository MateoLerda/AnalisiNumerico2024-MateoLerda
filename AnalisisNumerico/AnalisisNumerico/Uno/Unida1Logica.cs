using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Uno;
using Calculus;

namespace AnalisisNumerico.Unidad1
{
    internal class Unida1Logica
    {
        Calculo func = new Calculo();

        public Result CalculosU1(Datos datos) {
			Result result = new Result();

			if (datos.Metodo <= 1)
			{
				result = metodosCerrados(datos);
			}
			else {
				result = metodosAbiertos(datos);
			}

            return result;
        }
        //
        //---------------Funciones Metodos Abiertos----------------------------
        //
        private Result metodosAbiertos(Datos datos) { 
            Result result = new Result();
			if (func.Sintaxis(datos.Funcion, 'x'))
			{
                if (Math.Abs(func.EvaluaFx(datos.Xi)) < datos.Tolerancia)
                {
                    result.Raiz = datos.Xi;
                }
                else if (datos.Metodo == 3 && Math.Abs(datos.Xd) < datos.Tolerancia)
                {
					result.Raiz = datos.Xd;
				}
                else {
					double xrante = 0;
					double xr = 0;
					double error = 0;
                    int count = 0;
					for (int i = 0; i < datos.Iteraciones; i++)
					{
                        count = i;
                        xr = CalculoXr(datos);
                        if (double.IsNaN(xr)) {
                            result.Converge = false;
                            result.Error = "No puede encontrar raiz";
                            break;
                        }
						error = Math.Abs((xr - xrante) / xr);
                        if ((Math.Abs(func.EvaluaFx(xr)) < datos.Tolerancia) || error < datos.Tolerancia)
                        {
                            result.Converge = true;
                            break;
                        }
                        else {
                            if (datos.Metodo == 2)
                            {
                                datos.Xi = xr;
                            }
                            else {
                                datos.Xi = datos.Xd;
                                datos.Xd = xr;
                            }
                            xrante= xr;
                        }

					}
                    if (result.Converge) {
						result.Raiz = Math.Round(xr, 6);
						result.Interacciones = count;
						result.Error = (Math.Round(error, 8)).ToString("F6");
						result.Converge = true;
					}

				}
			}
			else
			{
				throw new Exception("Ingresa bien payaso");

			}
			return result;
        }
		//
		//---------------Funciones Metodos Cerrados----------------------------
		//
		private Result metodosCerrados(Datos datos) {
            Result result = new Result();
            if (func.Sintaxis(datos.Funcion, 'x'))
            {
                if ((func.EvaluaFx(datos.Xi) * func.EvaluaFx(datos.Xd)) == 0)
                {
                    if (func.EvaluaFx(datos.Xi) == 0)
                    {
                        result.Raiz = datos.Xi;                   
                    }
                    else
                    {
                        result.Raiz = datos.Xd;
					}
                }
                else if (((func.EvaluaFx(datos.Xi)) * (func.EvaluaFx(datos.Xd))) > 0)
                {
                    double conco = func.EvaluaFx(datos.Xi);
                    double agu = func.EvaluaFx(datos.Xd);
					// volver a ingresar xi y xd
					result.Error = "Ingresar nuevamente";
                }
                else {
					double xrante = 0;
                    double xr = 0;
                    double error = 0;
                    int count = 0;
                    for (int i = 0; i < datos.Iteraciones; i++) {
                        xr = CalculoXr(datos);
                        count = i;
                        error= Math.Abs((xr-xrante)/xr);
                        if (Math.Abs(func.EvaluaFx(xr)) < datos.Tolerancia || error < datos.Tolerancia) { 
                            break;
                        }
                        if ((func.EvaluaFx(datos.Xi) * func.EvaluaFx(xr)) > 0)
                        {
                            datos.Xi = xr;
                        }else { 
                            datos.Xd= xr;
                        }
                        xrante= xr;
                    }
					result.Raiz = Math.Round(xr, 6);
					result.Interacciones = count;
                    result.Error = (Math.Round(error, 8)).ToString("F6");
					result.Converge = true;
					return result;
				}
            }
            else {
                throw new Exception("Ingresa bien payaso");

            }
			return result;

		}

		//
		//---------------Calculo Xr----------------------------
		//
		private double CalculoXr(Datos dato) {
            double xr= new double();
            if (dato.Metodo % 2 != 0)
            {
               xr= dato.Xd - ((func.EvaluaFx(dato.Xd) *(dato.Xi-dato.Xd)))/ (func.EvaluaFx(dato.Xi)-func.EvaluaFx(dato.Xd));
			}
            else if (dato.Metodo == 0)
            {
                xr = (dato.Xi + dato.Xd) / 2;
            }
            else
            {
                double derivada = func.Dx(dato.Xi);
                xr = dato.Xi - (func.EvaluaFx(dato.Xi) / derivada);
            }
            return xr;
        }
    }
}
