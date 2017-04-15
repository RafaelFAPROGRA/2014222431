using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    public abstract class Servicio
    {
        public string TipoServicio { get; set; }
        public abstract void ServicioTipo();
    }
}
