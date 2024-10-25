using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Cuatro
{
    class Datos
    {
        public string Funcion { get; set; }
		public double Xi { get; set; }
        public double Xd { get; set; }
        public int CantidadSubInter { get; set; }
        public int Metodo { get; set; }
    }
}
