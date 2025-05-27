namespace TheSocialCues.Core
{
    public class Guest
    {
        public string Name { get; }

        public Guest(string name)
        {
            Name = name;
        }

        public int CurrentPhase { get; set; } = 1; // Default to Phase One
    }
}