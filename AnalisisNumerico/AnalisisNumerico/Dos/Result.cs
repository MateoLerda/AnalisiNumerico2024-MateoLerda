using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Dos
{
	internal class Result
	{
		public List<double> Resultados;
		public bool sucses;
		public string message;

		public Result(){
			Resultados = new List<double>();
		}
	}
}
