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

			result.EfectAjust= (r > data.Tolerancia)? true : false;
			result.Funcion = (a0 > 0)? $"{Math.Round(a1,3)}x +{Math.Round(a0,3)}": $"{Math.Round(a1, 3)}x {Math.Round(a0, 3)}";
			result.PorcentEfectiv = Math.Round(r,6).ToString();
            return result;
        }

        private Resultado RegrecionPolinomial(Data data)
        {
			Resultado result= new Resultado();
			return result;
        }
    }
}
