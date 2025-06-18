using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSocialCues.Tests;

namespace TheSocialCues.Core
{
    public class GameEngine
    {
        public void ExecuteInteraction(Player player, Guest guest, ConversationOption option)
        {
            if (option.Impact > 0)
            {
                guest.AdvancePhase();
            }
            else if (option.Impact < 0)
            {
                guest.RegressPhase();
            }
            // Later: Add support for neutral impact if needed
        }
    }
}
