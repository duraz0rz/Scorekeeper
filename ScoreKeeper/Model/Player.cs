using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper
{
    public enum PlayerEvent
    {
        Add,
        Subtract
    }

    public struct PlayerHistoryItem
    {
        public int Amount;
        public PlayerEvent Type;
    }

    public class Player
    {
        public String Name { get; set; }
        public int Score { get; private set; }
        public Stack<PlayerHistoryItem> History { get; private set;}

        public Player()
        {
            History = new Stack<PlayerHistoryItem>();
        }

        public void AddScore(int toAdd)
        {
            Score += toAdd;
            History.Push(new PlayerHistoryItem { Amount = toAdd, Type = PlayerEvent.Add });
        }

        public void SubtractScore(int toSubtract)
        {
            Score -= toSubtract;
            History.Push(new PlayerHistoryItem { Amount = toSubtract, Type = PlayerEvent.Subtract });
        }
    }
}
