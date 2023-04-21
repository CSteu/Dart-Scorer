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
		public int score;
		int dartsThrown;

		public Computer(int dif, int scr)
		{
			skillLevel = dif;
            score = scr;
		}

		public void calculateScore()
		{
            int dartsThrown = 0;
            int turnScore = 0;

            // Calculate the target score based on the difficulty level
            int targetScore = (int)Math.Round(20 * (0.6 + 0.05 * skillLevel) + 10);

            // Keep throwing darts until the target score is reached or exceeded
            while (turnScore < targetScore && score > 0)
            {
                // Simulate a dart throw by generating a random number between 1 and 20
                int dartScore = new Random().Next(1, 21);

                // If the dart hits a double or triple, multiply the score accordingly
                if (dartScore == 20)
                {
                    turnScore += 2 * dartScore;
                }
                else if (dartScore % 3 == 0)
                {
                    turnScore += (dartScore / 3) * 2;
                }
                else
                {
                    turnScore += dartScore;
                }

                dartsThrown++;
            }

            // If the target score was not reached, deduct the turn score from the total score
            if (turnScore < targetScore)
            {
                score -= turnScore;
            }
            else
            {
                // If the target score was reached exactly, reduce the score by the number of darts thrown
                score -= dartsThrown;
            }

            // If the score is low enough, try to take the game out by reaching a score of 0
            if (score <= targetScore / 2)
            {
                while (score > 0 && dartsThrown < 3)
                {
                    int dartScore = new Random().Next(1, 21);
                    if (dartScore == score)
                    {
                        score = 0;
                    }
                    else if (dartScore == 25 && score <= 50)
                    {
                        score -= 25;
                    }
                    else if (dartScore * 2 == score || dartScore * 3 == score)
                    {
                        score -= dartScore;
                    }
                    dartsThrown++;
                }
            }

            // If the score goes below 0, set it back to 0
            if (score < 0)
            {
                score = 0;
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
