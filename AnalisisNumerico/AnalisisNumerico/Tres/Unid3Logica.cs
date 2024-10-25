using AnalisisNumerico.Dos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Tres
{
	internal class Unid3Logica
	{
		public Resultado Calcular(Data data) { 
			Resultado resultado = new Resultado();
			if (data.Metodo == 0)
			{
				resultado = RegrecionLineal(data);
			}
			else { 
				resultado= RegrecionPolinomial(data);
			}
			return resultado;
		}

		private Resultado RegrecionLineal(Data data) {
            Resultado result = new Resultado();
			double sumX = 0;
			double sumY= 0;
			double sumXY= 0;
			double sumX2= 0;
			int n= data.Puntos.Count;
            foreach (var punto in data.Puntos)
            {
				sumX += punto[0];
				sumY += punto[1];
				sumXY += punto[0] * punto[1];
				sumX2 += punto[0] * punto[0];
            }
			double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX,2));
			double a0 = (sumY/n)-a1*(sumX/n);
			double sr = 0;
			double st = 0;
            foreach (var punto in data.Puntos)
            {
				st += Math.Pow((sumY / n - punto[1]),2);
				sr += Math.Pow((a1 * punto[0] + a0 - punto[1]), 2);
            }
			double r= Math.Sqrt((st-sr)/st)*100;

			result.EfectAjust= ((r/100) > data.Tolerancia)? true : false;
			result.Funcion = (a0 > 0)? $"{Math.Round(a1,3)}x +{Math.Round(a0,3)}": $"{Math.Round(a1, 3)}x {Math.Round(a0, 3)}";
			result.PorcentEfectiv = Math.Round(r,3).ToString();
            return result;
        }

        private Resultado RegrecionPolinomial(Data data)
        {
			Resultado result= new Resultado();
			Datos datos= new Datos();
			datos.dimension = data.Grado + 1;
			datos.Metodo = 0;
			datos.Matriz= GenerarMatrizPolinomial(data);
			Unidad2Logica logica2= new Unidad2Logica();
			Result resultado = logica2.CalculosU2(datos);
			string funcion = string.Empty;
			string signo= string.Empty;
            for (int i = 0; i < resultado.Resultados.Count; i++)
            {
				double ai = Math.Round(resultado.Resultados[i], 4);
				if (i == 0 && ai != 0)
				{
					funcion = $"{ai}";
				}
				else if (i == 1 && ai != 0)
				{
					funcion = $"{ai} x {signo}" + funcion;
				}
				else {
					if (ai != 0) { 
						funcion= $"{ai}x^{i} {signo}" +  funcion;
					}
				}
				signo = (ai>0)? "+": string.Empty;
            }
			result.Funcion = funcion;
			double x = 0;
			double y = 0;
			double sr = 0;
			double st = 0;
			double sumY=0;
			foreach (var punto in data.Puntos)
			{
				sumY += punto[1];
			}
			foreach (var punto in data.Puntos)
            {
				x = punto[0];
				y= punto[1];
				double suma = 0;
                for (int i = 0; i < resultado.Resultados.Count; i++)
                {
					suma += resultado.Resultados[i] * Math.Pow(x, i);
                }
				sr += Math.Pow(suma - y, 2);
				st += Math.Pow(sumY/data.Puntos.Count-y, 2);
            }
			double r = Math.Sqrt((st - sr) / st) * 100;
			result.EfectAjust = ((r/100) > data.Tolerancia) ? true : false;			
			result.PorcentEfectiv = Math.Round(r, 3).ToString();
			return result;
        }

		private double[,] GenerarMatrizPolinomial(Data data) {
			int dimension = data.Grado + 1;
			double[,] matriz= new double[dimension,dimension+1];
			double x = 0;
			double y = 0;
            foreach (var punto in data.Puntos)
            {
				x = punto[0];
				y = punto[1];
                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
						matriz[fila, col] += Math.Pow(x,fila+col);
                    }
					matriz[fila, dimension] += y * Math.Pow(x, fila);
                }
            }
			return matriz;
        }
    }
}
