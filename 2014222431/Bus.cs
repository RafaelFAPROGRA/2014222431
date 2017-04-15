using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    class Bus
    {
        string tipobus { get; set; }
        private List<Tripulacion> _Tripulación;
        public List<Tripulacion> Tripulación
        {
            get
            {
                return _Tripulación;
            }
            set
            {
                if(value.Count==15)
                { _Tripulación = value; }

            }
            
        }
        public Bus(List<Tripulacion> tripulación)
        {
            Tripulación = tripulación;
        }
    }
}
