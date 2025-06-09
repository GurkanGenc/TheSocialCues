namespace TheSocialCues.Tests
{
    public class ConversationOption
    {
        public string Text { get; }
        public int Impact { get; }

        public ConversationOption(string text, int impact)
        {
            Text = text;
            Impact = impact;
        }
    }
}