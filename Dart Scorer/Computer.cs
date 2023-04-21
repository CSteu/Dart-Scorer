using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartScorer.Untitled
{
	public class Computer
	{
		string name = "Dartbot";
		int skillLevel;
		int score;
		int dartsThrown;

		public Computer()
		{
			
		}

		public int calculateScore(int startScore)
		{
			return startScore - score;
		}

		public int getScore()
		{
			return score;
		}

		public void resetScore()
		{
			score = 0;
		}

		public void incrementDarts()
		{
			dartsThrown++;
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
