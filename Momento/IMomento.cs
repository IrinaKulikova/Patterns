namespace Momento
{
    public interface IMemento
    {
        string Color { get; set; }
        int X { get; set; }
        int Y { get; set; }

        string Info();
    }
}
