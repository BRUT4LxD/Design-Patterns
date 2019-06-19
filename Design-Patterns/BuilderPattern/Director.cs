namespace BuilderPattern
{
    internal class Director
    {
        public House BuildHouse(IHouseBuilder houseBuilder)
        {
            houseBuilder.BuildBackyard();
            houseBuilder.BuildSwimmingPool();
            return houseBuilder.GetHouse();
        }
    }
}