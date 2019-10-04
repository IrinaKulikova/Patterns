namespace Momento
{
    class Memento : IMemento
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Memento(string color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }

        public string Info()
        {
            return "Circle " + Color + " center(" + X +":" + Y + ")";
        }
    }
}
