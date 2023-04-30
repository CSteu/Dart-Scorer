using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dart_Scorer
{
    public abstract class Player : DartScorer.Untitled.User
    {
        public string name;
        public int score;
        public int dartsThrown;
        public int legs = 0;

        public DartScorer.Untitled.StatsSheet StatsSheet
        {
            get => default;
            set
            {
            }
        }

        public DartScorer.Untitled.User User
        {
            get => default;
            set
            {
            }
        }

        public void incrementLegs()
        {
            legs++;
        }

        public abstract void decrementScore(int lastTurn);

        public void incrementDarts(int darts)
        {
            dartsThrown += darts;
        }

        public int getDarts()
        {
            return dartsThrown;
        }

        public void resetDarts()
        {
            dartsThrown = 0;
        }
    }
}
