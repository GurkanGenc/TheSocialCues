using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSocialCues.Core;

namespace TheSocialCues.Tests
{
    [TestClass]
    public class GuestTests
    {
        [TestMethod]
        public void Guest_ShouldStartAtPhaseOne()
        {
            // Arrange
            var guest = new Guest("Anna");
            var expected = 1;
            // Act
            var actual = guest.CurrentPhase;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
