using TheSocialCues.Core;

namespace TheSocialCues.Tests;

[TestClass]
public class GameEngineTests
{
    [TestMethod]
    public void ExecuteInteraction_PositiveImpact_IncreasesGuestConnectionLevel()
    {
        //Arrange
        var engine = new GameEngine();
        var player = new Player("TestPlayer");
        var guest = new Guest("TestGuest");
        var interaction = new ConversationOption("PositiveInteraction", 1);

        // Act
        engine.ExecuteInteraction(player, guest, interaction);

        // Assert
        Assert.AreEqual(ConnectionLevel.Acquaintance, guest.CurrentLevel);
    }

    [TestMethod]
    public void ExecuteInteraction_NegativeImpact_DecreasesGuestConnectionLevel()
    {
        // Arrange
        var engine = new GameEngine();
        var player = new Player("TestPlayer");
        var guest = new Guest("TestGuest");
        var interaction = new ConversationOption("NegativeInteraction", -1);
        // Act
        engine.ExecuteInteraction(player, guest, interaction);
        // Assert
        Assert.AreEqual(ConnectionLevel.Stranger, guest.CurrentLevel);
    }
}
