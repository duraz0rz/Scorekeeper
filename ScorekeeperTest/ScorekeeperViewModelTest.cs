using System;
using GalaSoft.MvvmLight;
using ScoreKeeper.ViewModel;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace ScorekeeperTest
{
    [TestClass]
    class ScorekeeperViewModelTest
    {
        ScorekeeperViewModel scoreKeeper = null;

        [TestInitialize]
        public void Setup()
        {
            scoreKeeper = new ScorekeeperViewModel();
        }
    }
}
