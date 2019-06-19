using System;

namespace BuilderPattern
{
    internal class SmallHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new House();
        public void BuildBackyard()
        {
            Console.WriteLine("Building no backyard");
            _house.BackYard = false;
        }

        public void BuildSwimmingPool()
        {
            Console.WriteLine("Building swimming pool with holes");
            _house.SwimmingPool = true;
        }

        public House GetHouse() => _house;
    }
}
