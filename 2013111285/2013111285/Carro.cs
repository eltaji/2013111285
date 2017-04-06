using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285
{
    class Carro
    {
        Llanta _llanta;
        Asiento _asiento;
        Cinturon _cinturon;
        Parabrisas _parabrisas;
        Volante _volante;

        public string numSerieMotor { get; set; }
        public string numSerieChasis { get; set; }

        public Carro(string _numSerieMotor, string _numSerieChasis)
        {
            numSerieMotor = _numSerieMotor;
            numSerieChasis = _numSerieChasis;

            _llanta = new Llanta();
            _asiento = new Asiento();
            _cinturon = new Cinturon();
            _parabrisas = new Parabrisas();
            _volante = new Volante();
        }

        public Carro()
        {


        }
    }
}
