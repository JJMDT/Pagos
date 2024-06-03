using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos
{
    internal class PagoConEfectivo:Pago,IValidar
    {
        public float montoRecibido;
        public string nombreCliente;

        public PagoConEfectivo(float monto,float montoRecibido,string nombreCliente):base (monto)
        {
            this.monto=monto;
            this.montoRecibido=montoRecibido;
            this.nombreCliente=nombreCliente;
        }
        public override void MostrarRecibo()
        {
            Console.WriteLine(" fecha de transaccion : {0} \n importe abonado: ${1} \n medio de pago: {2}", fecha, monto,GetType());
        }
        public override void ProcesarPago()
        {
            if (Validar())
            {
                float vuelto = montoRecibido - monto;

                Console.WriteLine("pago exitoso");
                Console.WriteLine("el vuelto es ${0}",vuelto);
                MostrarRecibo();
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        public bool Validar()
        {
            if(montoRecibido < monto)
            {
                
                return false;
            }else
            {

            return true;
            }
        }
    }
}
