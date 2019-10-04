using System.Collections.Generic;

namespace Mediator
{
    public class Chatroom : IChatroom
    {
        private Dictionary<string, IParticipant> _participants =
          new Dictionary<string, IParticipant>();

        public void Register(IParticipant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            _participants.TryGetValue(to, out IParticipant participant);

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
