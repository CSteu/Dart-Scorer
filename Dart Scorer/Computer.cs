using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartScorer.Untitled
{
	public class Computer
	{
		public string name = "Dartbot";
		int skillLevel;
		public int score;
		public int dartsThrown;
		public int[] turns = new int[100];
		private int currTurn = 0;
		public int legs = 0;

		public Computer(int dif, int scr)
		{
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
				score -= currScore;
				if (score - currScore < 0)
					score = 0;
			}
			else
			{
				score -= currScore;
			}
			
			return currScore;
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

		public void resetScore()
		{
			score = 0;
		}

		public void incrementDarts(int num)
		{
			dartsThrown += num;
		}

        public void incrementLegs()
        {
            legs++;
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
