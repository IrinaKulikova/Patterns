namespace Mediator
{
    public interface IChatroom
    {
        void Register(IParticipant participant);
        void Send(string from, string to, string message);
    }
}
