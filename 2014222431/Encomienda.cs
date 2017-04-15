using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    class Encomienda : Servicio
    {
        public new string TipoServicio { get; set; }
        public override void ServicioTipo()
        {
            TipoServicio.Equals("Servicio Encomienda");
            Console.WriteLine("Servicio de encomienda");
           
        }
    }
}
