using System;

namespace FabricPattern
{
    internal class Ship : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Shuuuummm....");
        }

        public void DoSth()
        {

            Console.WriteLine("Hello from Ship");
        }
    }
}
