using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285
{
    public class Cinturon
    {


        public int Metraje { get; set; }

        public string NumSerie { get; set; }

        public Cinturon()
        {

        }

        public Cinturon(int _Metraje, string _NumSerie)
        {

            Metraje = _Metraje;
            NumSerie = _NumSerie;
        }
    }
}
