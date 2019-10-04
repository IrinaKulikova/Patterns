namespace Builder
{
    public interface IBuilder
    {
        void BuildBasement();
        void BuildStorey();
        void BuildRoof();
        House GetResult();
    }
}
