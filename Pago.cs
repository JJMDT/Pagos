using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos
{
    abstract class Pago
    {
        public float monto;
        public DateTime fecha;

        public Pago(float monto)
        {
            this.monto = monto;
            this.fecha = DateTime.Now;
        }

        public abstract void ProcesarPago(float importe);
        public abstract void MostrarRecibo();

    }
}
