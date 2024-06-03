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
        public long nroTarjeta;

        public PagoConTarjeta(float monto,long nroTarjeta) : base(monto)
        {
            this.monto = monto;
            this.fecha= DateTime.Now;
            this.nroTarjeta = nroTarjeta;


        }
        public override void ProcesarPago()
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
            Console.WriteLine(" fecha de transaccion : {0} \n importe abonado: ${1} \n medio de pago: {2}",fecha,monto,GetType());
        }
        public bool Validar()
        {
            if(nroTarjeta == 0)
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
