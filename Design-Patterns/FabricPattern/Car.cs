using System;

namespace FabricPattern
{
    internal class Car : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Brum burm");
        }

        public void DoSth()
        {
            Console.WriteLine("Hello from Car");
        }
    }
}
