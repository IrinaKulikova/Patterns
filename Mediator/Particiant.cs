using System;

namespace Mediator
{
    public class Participant : IParticipant
    {
        public string Name { get; private set; }

        public IChatroom Chatroom { get; set; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'\n", from, Name, message);
        }
    }
}
