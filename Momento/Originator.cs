namespace Momento
{
    class Originator
    {
        private string _color;
        private int _x;
        private int _y;

        public Originator(string color, int x, int y)
        {
            _color = color;
            _x = x;
            _y = y;
        }
        public IMemento Save()
        {
            return new Memento(_color, _x, _y);
        }

        public void Restore(IMemento memento)
        {
            _color = memento.Color;
            _x = memento.X;
            _y = memento.Y;
        }
    }
}