using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.ViewModel
{
    public class ScorekeeperViewModel : ViewModelBase
    {
        public ObservableCollection<Player> Players { get; set; }

        public ScorekeeperViewModel()
        {
            Players = new ObservableCollection<Player>();
        }

        public void AddPlayer(string name, int score = 0)
        {
            Players.Add(new Player(20) { Name = name });
        }
    }
}
