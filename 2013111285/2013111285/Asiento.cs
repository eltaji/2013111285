using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285
{
    class Asiento
    {
        Cinturon _cinturon;

        public string NumSerie { get; set; }

        public Asiento()
        {


       }

        public Asiento(String _numSerie)
        {
            NumSerie = _numSerie;
            _cinturon = new Cinturon();
        }
    }

}
