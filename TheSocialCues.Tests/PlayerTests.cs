using TheSocialCues.Core;

namespace TheSocialCues.Tests;

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void Constructor_ValidName_NameIsSetCorrectly()
    {
        // Arrange
        string expectedName = "John Doe";
        // Act
        Player player = new Player(expectedName);
        // Assert
        Assert.AreEqual(expectedName, player.Name);
    }
}
