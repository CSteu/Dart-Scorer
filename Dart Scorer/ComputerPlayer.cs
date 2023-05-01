using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dart_Scorer;

namespace DartScorer.Untitled
{
	public class ComputerPlayer : Player
	{
		private int skillLevel;
		private int[] turns = new int[100];
		private int currTurn = 0;

		public ComputerPlayer(int dif, int scr)
		{
            name = "Dartbot";
            skillLevel = dif;
            score = scr;
			generateTurns();
		}

		public int calculateScore()
		{
			int currScore = turns[currTurn];
            currTurn++;
			if(score < 160)
			{
				currScore /= 2;
				decrementScore(currScore);
				if (score - currScore < 0)
					score = 0;
			}
			else
			{
				score -= currScore;
			}
			
			return currScore;
        }

        public override void decrementScore(int lastTurn)
        {
            score -= turns[currTurn];
        }

        public void generateTurns()
		{
			Random rand = new Random();
			int currScore;
            int targetScore = 20 * skillLevel + 10;		
            int targetTurns = score / targetScore + 1;
			int targetAverage = targetScore / targetTurns;

			for(int i = 0; i < 100; i++)
			{
				currScore = targetScore + rand.Next(-10*skillLevel, 10*skillLevel);
				turns[i] = currScore;
			}
        }

		public int getScore()
		{
			return score;
		}

	}
}
