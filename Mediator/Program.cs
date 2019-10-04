using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatroom chatroom = new Chatroom();

            var Nina = new Participant("Nina");
            var Vitaliy = new Participant("Vitaliy");
            var Anna = new Participant("Anna");
            var Alex = new Participant("Alex");
            var Nikolay = new Participant("Nikolay");

            chatroom.Register(Nina);
            chatroom.Register(Vitaliy);
            chatroom.Register(Anna);
            chatroom.Register(Alex);
            chatroom.Register(Nikolay);

            Nina.Send("Vitaliy", "Hi Vitaliy!");
            Vitaliy.Send("Alex", "Hello my fiend!");
            Anna.Send("Nikolay", "Hello!");
            Alex.Send("Anna", "Have a good day!");
            Nikolay.Send("Nina", "Good luck!");

            Console.ReadKey();
        }
    }
}
