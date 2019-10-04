namespace Mediator
{
    public interface IParticipant
    {
        string Name { get; }
        IChatroom Chatroom { get; set; }

        void Send(string to, string message);
        void Receive(string from, string message);
    }
}
