using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    public class Transporte: Servicio
    {
        public override void ServicioTipo()
        {
            Console.WriteLine("Servicio de Transporte");

        }
        private List<Bus> _Bus;
        public List<Bus> Bus
        {
            get
            {
                return _Bus;
            }
            set
            {
                if (value.Count == 50)
                { _Bus = value; }

            }

        }
        public Bus(List<Bus> bus)
        {
            Bus = bus;
        }
    }
}
