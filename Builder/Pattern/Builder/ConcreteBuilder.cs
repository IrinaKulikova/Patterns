namespace Builder
{
    class ConcreteBuilder : IBuilder
    {
        House house = new House();

        public void BuildBasement()
        {
            house.Add(new Basement());
        }

        public void BuildStorey()
        {
            house.Add(new Storey());
        }

        public void BuildRoof()
        {
            house.Add(new Roof());
        }

        public House GetResult()
        {
            return house;
        }
    }
}
