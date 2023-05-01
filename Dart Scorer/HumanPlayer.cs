using Dart_Scorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartScorer.Untitled
{
	public class HumanPlayer : Player
	{

		public HumanPlayer()
		{
			name = "Player";
		}

		public HumanPlayer(string player, int startScore)
		{
			name = player;
			score = startScore;
		}

		public override void decrementScore(int lastTurn)
		{
			score -= lastTurn;
		}

		public int getScore()
		{
			return score;
		}
	}
}
