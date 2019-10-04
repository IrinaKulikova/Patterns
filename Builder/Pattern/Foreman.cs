namespace Builder
{
    class Foreman
    {
        IBuilder builder;

        public Foreman(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
