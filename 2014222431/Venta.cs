using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222431
{
    class Venta
    {
        private List<Administrativo> _Administrativo;
        private List<Cliente> _Cliente;
        private List<Servicio> _Servicio;
        private List<TipoComprobante> _TipoComprobante;
        private List<TipoPago> _TipoPago;

        public List<Cliente> Cliente
        {
            get { return _Cliente; }
            private set { _Cliente = value; }
        }
        public List<Administrativo> Administrativo
        {
            get { return _Administrativo; }
            private set { _Administrativo = value; }
        }
        public List<Servicio> Servicio
        {
            get { return _Servicio; }
            private set { _Servicio = value; }
        }
        public List<TipoPago> TipoPago
        {
            get { return _TipoPago; }
            private set { _TipoPago = value; }
        }
        public List<TipoComprobante> TipoComprobante
        {
            get { return _TipoComprobante; }
            private set { _TipoComprobante = value; }
        }

        public Venta()
        {
            Cliente = new List<Cliente>();
            Administrativo = new List<Administrativo>();
            Servicio = new List<Servicio>();
            TipoComprobante = new List<TipoComprobante>();
            TipoPago = new List<TipoPago>();

        }
        public void AgregarTipoBus(string TipoViaje)
        {
           
        }
        public void MostrarViaje(string viaje1, string viaje2, string viaje3)
        {
            
                Console.WriteLine("Viaje 1 a" + viaje1);
            Console.WriteLine("Viaje 2 a" + viaje2);
            Console.WriteLine("Viaje 3 a" + viaje3);
              
        }
        public void MostrarEncomienda(string encomienda1, string encomienda2)
        {
           
                Console.WriteLine("Encomienda 1 a:" + encomienda1);
                Console.WriteLine("Encomienda 2 a:" + encomienda2);
         
        }
    }
}
