namespace TheSocialCues.Tests;

[TestClass]
public class ConversationOptionTests
{
    [TestMethod]
    public void ConversationOption_ShouldStoreTextAndImpactCorrectly()
    {
        // Arrange
        var option = new ConversationOption("Hey", 1);

        Assert.AreEqual("Hey", option.Text);
        Assert.AreEqual(1, option.Impact);
    }

    [TestMethod]
    public void ConversationOption_ShouldAcceptNegativeImpact()
    {
        // Arrange
        var option = new ConversationOption("Oh no", -1);
        // Act & Assert
        Assert.AreEqual("Oh no", option.Text);
        Assert.AreEqual(-1, option.Impact);
    }
}
