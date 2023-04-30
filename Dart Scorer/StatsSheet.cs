using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartScorer.Untitled
{
	public class StatsSheet
	{
		public float[] average = new float[5];
        public float[] firstNine = new float[5];
		public int[] totalPoints = new int[5];
		public int[] totalDarts = new int[5];

        public StatsSheet()
		{
			for(int k = 0; k < 5; k++)
			{
				totalPoints[k] = 0;
				totalDarts[k] = 0;
			}
		}



		public void calculateAverage(int playerNum)
		{
			average[playerNum] = (float)totalPoints[playerNum] / totalDarts[playerNum];
		}

        public float threeDartAverage(int playerNum)
		{
			return average[playerNum] * 3;
		}

		public void addScore(int score, int player)
		{
			totalPoints[player] += score;
		}

        public void addDarts(int darts, int player)
        {
            totalDarts[player] += darts;
        }
    }
}
