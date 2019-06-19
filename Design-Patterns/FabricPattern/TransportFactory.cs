using System;

namespace FabricPattern
{
    internal static class TransportFactory
    {
        public static ITransport CreateTransport(TransportType type)
        {
            switch (type)
            {
                case TransportType.Car:
                    return new Car();
                case TransportType.Ship:
                    return new Ship();
                case TransportType.Unknown:
                    return null;
                default:
                    Console.WriteLine("Unknown transport machine");
                    return null;
            }
        }
    }
}
