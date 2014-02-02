using System;
using GalaSoft.MvvmLight;
using ScoreKeeper;
using ScoreKeeper.ViewModel;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.ObjectModel;

namespace ScorekeeperTest
{
    [TestClass]
    public class ScorekeeperViewModelTest
    {
        [TestMethod]
        public void AddPlayerAddsAPlayerToTheGameWithNoScoreAsDefault()
        {
            var scoreKeeper = new ScorekeeperViewModel();
            scoreKeeper.AddPlayer("MEOW");

            var playerCollection = scoreKeeper.Players;
            Assert.AreEqual(1, playerCollection.Count);
            Assert.AreEqual("MEOW", playerCollection[0].Name);
            Assert.AreEqual(0, playerCollection[0].Score);            
        }

        [TestMethod]
        public void AddPlayerAddsAPlayerToTheGameWithASetScore()
        {
            var scoreKeeper = new ScorekeeperViewModel();
            scoreKeeper.AddPlayer("MEOW", 20);

            var playerCollection = scoreKeeper.Players;
            Assert.AreEqual(1, playerCollection.Count);
            Assert.AreEqual("MEOW", playerCollection[0].Name);
            Assert.AreEqual(20, playerCollection[0].Score);   
        }

        // Delete player
        // Change score
        // Reset game
        // View history
    }
}
