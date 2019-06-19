namespace BuilderPattern
{
    internal interface IHouseBuilder
    {
        void BuildBackyard();
        void BuildSwimmingPool();
        House GetHouse();
    }
}
