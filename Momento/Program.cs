using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator("RED", 0, 0);
            var caretaker = new CaretakerMemory(originator);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Save");
            caretaker.Backup();
            History(caretaker);

            Restore(originator, caretaker, "BLUE", -100, 100);
            Restore(originator, caretaker, "YELLOW", 20, 20);
            Undo(caretaker);
            Undo(caretaker);
            Redo(caretaker);
            History(caretaker);

            Console.ReadKey();
        }

        private static void History(CaretakerMemory caretaker)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("History states: ");
            caretaker.ShowHistory();
        }

        private static void Restore(Originator originator,
                                    CaretakerMemory caretaker,
                                    string color,
                                    int x, int y)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Restore new memento");
            originator.Restore(new Memento(color, x, y));
            caretaker.Backup();
            Console.WriteLine("Current state: ");
            caretaker.ShowCurrentState();
        }

        private static void Redo(CaretakerMemory caretaker)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Redo: ");
            caretaker.Redo();
            Console.WriteLine("Current state: ");
            caretaker.ShowCurrentState();
        }

        private static void Undo(CaretakerMemory caretaker)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Undo: ");
            caretaker.Undo();
            Console.WriteLine("Current state: ");
            caretaker.ShowCurrentState();
        }
    }
}
