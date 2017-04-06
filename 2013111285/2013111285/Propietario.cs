using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285
{
    class Propietario
    {
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string licenciaConducir { get; set; }

        public Propietario()
        {

        }

        public Propietario(string _dni, string _nombres, string _apellidos, string _licenciaConducir)
        {
            dni = _dni;
            nombres = _nombres;
            apellidos = _apellidos;
            licenciaConducir = _licenciaConducir;
        }
    }
}
