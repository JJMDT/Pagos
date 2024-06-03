namespace Pagos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var juanTarjeta = new PagoConTarjeta(15550, 01);
            var juanEfectivo = new PagoConEfectivo(5200, 5500, "jose luis");
            juanTarjeta.ProcesarPago();
            juanEfectivo.ProcesarPago();
        }
    }
}