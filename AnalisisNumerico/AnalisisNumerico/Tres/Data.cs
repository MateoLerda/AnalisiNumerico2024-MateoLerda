using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Tres
{
	internal class Data
	{

		public Data() { 
			Puntos =  new List<double[]>();
		}
		public List<double[]> Puntos;
		public  double Tolerancia { get; set; }
		public int Metodo { get; set; }
		public int Grado { get; set; }

	}
}
