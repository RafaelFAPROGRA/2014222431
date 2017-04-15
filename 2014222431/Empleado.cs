using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    public interface Empleado
    {
        int EmpleadoID { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Cargo { get; set; }
        
    }
}
