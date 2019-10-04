using System;
using System.Collections.Generic;
using System.Linq;

namespace Momento
{
    class CaretakerMemory
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        private int _current = 0;

        public CaretakerMemory(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            IMemento memento = _originator.Save();
            _mementos.Add(memento);
            _current = _mementos.IndexOf(memento);
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            if (_current > 0)
            {
                _current--;
                _originator.Restore(_mementos[_current]);
            }
        }

        internal void Redo()
        {
            if (_current < _mementos.Count - 1)
            {
                _current++;
                _originator.Restore(_mementos[_current]);
            }
        }

        public void ShowCurrentState()
        {
            Console.WriteLine(_mementos[_current].Info());
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.Info());
            }
        }
    }
}