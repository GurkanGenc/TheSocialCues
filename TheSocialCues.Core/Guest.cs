
namespace TheSocialCues.Core
{
    public class Guest
    {
        public string Name { get; }

        public Guest(string name)
        {
            Name = name;
        }

        public ConnectionLevel CurrentPhase { get; private set; } = ConnectionLevel.Stranger;

        public void AdvancePhase()
        {
            CurrentPhase++;
        }
    }
}