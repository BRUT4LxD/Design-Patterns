using System;

namespace FabricPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITransport vehicle = TransportFactory.CreateTransport(TransportType.Car);
            vehicle.Move();
            Console.ReadKey();


            ITransport vehicle2 = TransportFactory.CreateTransport(TransportType.Ship);
            vehicle2.Move();
            Console.ReadKey();
        }
    }
}
