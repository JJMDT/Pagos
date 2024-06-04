using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pagos
{
    internal class PagoConTarjeta: Pago,IValidar
    {
        public string nroTarjeta;
        public string nombre;


        public PagoConTarjeta(float monto, string nroTarjeta,string nombre) : base(monto)
        {
            this.monto = monto;
            this.fecha = DateTime.Now;
            this.nroTarjeta = nroTarjeta;
            this.nombre = nombre;


        }
      
        public override void ProcesarPago(float importe)
        {
            if (Validar())
            {

            Console.WriteLine("procesando pago... \n pago exitoso");
                MostrarRecibo();
            }
            else
            {
                Console.WriteLine("error de pago");
                Console.WriteLine("tarjeta invalida");
            }
        }
        public override void MostrarRecibo()
        {
            Console.WriteLine("***** recibo *****");
            Console.WriteLine(" fecha de transaccion : {0} \n importe abonado: ${1} \n medio de pago: {2}\n titular de la tarjeta: {3}",fecha,monto,GetType().Name,nombre);
        }
        public bool Validar()
        {
            if(nroTarjeta == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
