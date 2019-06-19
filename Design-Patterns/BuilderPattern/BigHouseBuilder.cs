using System;

namespace BuilderPattern
{
    internal class BigHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new House();
        public void BuildBackyard()
        {
            Console.WriteLine("Building beautiful backyard");
            _house.BackYard = true;
        }

        public void BuildSwimmingPool()
        {
            Console.WriteLine("Building gigantic swimming pool");
            _house.SwimmingPool = true;
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
