using System;
using ScoreKeeper;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace ScorekeeperTest
{
    [TestClass]
    public class PlayerTest
    {
        Player player = null;

        [TestInitialize]
        public void Setup()
        {
            player = new Player();
        }

        [TestMethod]
        public void PlayerNameGetsSetCorrectly()
        {
            player.Name = "UNITTEST";
            Assert.AreEqual<String>("UNITTEST", player.Name);
        }

        [TestMethod]
        public void PlayerScoreGetsInitializedToZero()
        {
            Assert.AreEqual<int>(0, player.Score);
        }

        [TestMethod]
        public void PlayerScoreGetsAddedCorrectly()
        {
            player.AddScore(20);
            Assert.AreEqual<int>(20, player.Score);
        }

        [TestMethod]
        public void PlayerScoreGetsSubtractedCorrectly()
        {
            player.SubtractScore(20);
            Assert.AreEqual<int>(-20, player.Score);
        }

        [TestMethod]
        public void PlayerHistoryGetsUpdatedWhenScoreIsAdded()
        {
            Assert.IsTrue(player.History.Count == 0, "History count is not zero!");
            player.AddScore(20);
            Assert.IsTrue(player.History.Count == 1, "History count is not one!");

            PlayerHistoryItem currentHistory = player.History.Peek();

            Assert.AreEqual<int>(20, currentHistory.Amount);
            Assert.AreEqual<PlayerEvent>(PlayerEvent.Add, currentHistory.Type);
        }

        [TestMethod]
        public void PlayerHistoryGetsUpdatedWhenScoreIsSubtracted()
        {
            Assert.IsTrue(player.History.Count == 0, "History count is not zero!");
            player.SubtractScore(20);
            Assert.IsTrue(player.History.Count == 1, "History count is not one!");

            PlayerHistoryItem currentHistory = player.History.Peek();

            Assert.AreEqual<int>(20, currentHistory.Amount);
            Assert.AreEqual<PlayerEvent>(PlayerEvent.Subtract, currentHistory.Type);
        }
    }
}
