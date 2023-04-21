using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartScorer.Untitled
{
	public class Player
	{
		public string name;
		public int score;
		public int dartsThrown;

		public Player()
		{
			name = "Player";
		}

		public Player(string player, int startScore)
		{
			name = player;
			score = startScore;
		}

		public void decrementScore(int lastTurn)
		{
			score -= lastTurn;
		}

		public int getScore()
		{
			return score;
		}

		public void resetScore()
		{
			score = 0;
		}

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
