using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dart_Scorer
{
    public abstract class Player 
    {
        public string name;
        public int score;
        public int dartsThrown;
        public int legs = 0;

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
