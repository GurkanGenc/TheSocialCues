

namespace TheSocialCues.Core
{
    public class Guest
    {
        public string Name { get; }

        public Guest(string name)
        {
            Name = name;
        }

        public ConnectionLevel CurrentLevel { get; private set; } = ConnectionLevel.Stranger;

        public void AdvancePhase()
        {
            if (CurrentLevel < ConnectionLevel.Comfortable)
                CurrentLevel++;
        }

        public void RegressPhase()
        {
            if (CurrentLevel > ConnectionLevel.Stranger)
            {
                CurrentLevel--;
            }
        }
    }
}