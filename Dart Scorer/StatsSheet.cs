using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartScorer.Untitled
{
	public class StatsSheet
	{
		public float[] average = new float[4];
        public float[] firstNine = new float[4];
		public int[] totalPoints = new int[4];
		public int[] totalDarts = new int[4];

		public float caverage;
		public float cfirstNine;
		public int ctotalPoints;
        public int ctotalDarts;


        public StatsSheet()
		{
			for(int k = 0; k < 4; k++)
			{
				totalPoints[k] = 0;
				totalDarts[k] = 0;
			}
			ctotalDarts = 0;
			ctotalPoints = 0;
		}



		public void calculateAverage(int playerNum)
		{
			average[playerNum] = (float)totalPoints[playerNum] / totalDarts[playerNum];
		}

        public void calculateComputerAverage()
        {
            caverage = (float)ctotalPoints / ctotalDarts;
        }

        public void firstNineAverage()
		{
			throw new NotImplementedException();
		}

		public void addScore(int score, int player)
		{
			totalPoints[player] += score;
		}

        public void addDarts(int darts, int player)
        {
            totalDarts[player] += darts;
        }

		public void addComputerScore(int score)
		{
			ctotalPoints += score;
		}
        public void addComputerDarts(int darts)
        {
            ctotalDarts += darts;
        }
    }
}
