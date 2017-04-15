using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    class Program
    {
        static void Main(string[] args)
        {
            var encomienda1="Tacna";
            var encomienda2="Arequipa";
            var encomienda3="Lima";
            var viaje1="Trujillo";
            var viaje2="Cajamarca";
            var ventas = new Venta();

            ventas.MostrarEncomienda(encomienda1, encomienda2, encomienda3);
            ventas.MostrarViaje(viaje1, viaje2);

            
        }
    }
}
