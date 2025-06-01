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
            var expected = ConnectionLevel.Stranger;

            // Act
            var actual = guest.CurrentLevel;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Guest_ShouldAdvancePhase()
        {
            // Arrange
            var guest = new Guest("Anna");
            guest.AdvancePhase(); // Simulate advancing to Phase Two
            var expected = ConnectionLevel.Acquaintance;
            // Act
            var actual = guest.CurrentLevel;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Guest_ShouldNotAdvanceBeyondComfortable()
        {
            // Arrange
            var guest = new Guest("Anna");
            guest.AdvancePhase(); // Phase Two
            guest.AdvancePhase(); // Phase Three
            guest.AdvancePhase(); // Phase Four (Comfortable)
            guest.AdvancePhase(); // Should not advance beyond Comfortable
            var expected = ConnectionLevel.Comfortable;

            // Act
            var actual = guest.CurrentLevel;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
