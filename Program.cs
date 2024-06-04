namespace Pagos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        

            Console.WriteLine("ingrese el importe a pagar");
            float importe = float.Parse(Console.ReadLine());
            Console.WriteLine("forma de pago");
            Console.WriteLine("1-efectivo \n2-tarjeta \n0-cancelar");
            int respuesta = int.Parse(Console.ReadLine());
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("ingresar monto recibido");
                    float montoRecibido = float.Parse(Console.ReadLine());
                    var pagoEnEfectivo = new PagoConEfectivo(importe, montoRecibido,"xxx");
                    pagoEnEfectivo.ProcesarPago(importe);
                    break;
                case 2:
                    
                    Console.WriteLine("ingresar nombre ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingresar numero de tarjeta");
                    string nroTarjeta = Console.ReadLine();
                    var pagoEnTarjeta = new PagoConTarjeta(importe,nroTarjeta,nombre);
                    pagoEnTarjeta.ProcesarPago(importe);
                    break;
                case 0:
                    break;
            }
        }
    }
}