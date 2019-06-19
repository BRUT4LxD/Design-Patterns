using System;
using System.IO;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Director director = new Director();

            House bigHouse = director.BuildHouse(new BigHouseBuilder());
            House smallHouse = director.BuildHouse(new SmallHouseBuilder());

            Console.ReadKey();
        }
    }
}
