using DartScorer.Untitled;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dart_Scorer
{
    public partial class Game : Form
    {
        public int startScore;
        public int numPlayers;
        
        StatsSheet statsSheet = new StatsSheet();
        public Game(int score, int num)
        {
            InitializeComponent();
            gameSetup();
            startScore = score;
            numPlayers = num;
        }
        Player[] player = new Player[]
        {
            new Player("player 1", 501),
            new Player("player 2", 501),
            new Player("player 3", 501),
            new Player("player 4", 501)
        };

        int turn = 0;
        public void gameSetup()
        {
            txtCurrPlayer.Text = player[0].name;
            txtScore.Text = player[0].getScore().ToString();
            txtPlayerList.Text = player[0].name + ": " + player[0].getScore() + "\n" + player[1].name + ": " + player[1].getScore();
        }

        public void updateGame()
        {
            int upnext = (turn + 1) % numPlayers;
            txtCurrPlayer.Text = player[upnext].name;
            txtScore.Text = player[upnext].getScore().ToString();
            txtPlayerList.Clear();
            for (int i = 0; i < numPlayers; i++)
            {
                txtPlayerList.Text += player[i].name + ": " + player[i].getScore() + "\n";
                txtPlayerList.Text += "Average: " + statsSheet.average[i] + "\n";
            }
        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            int up = turn % numPlayers;
            player[up].decrementScore(int.Parse(txtCurrScore.Text));
            statsSheet.addScore(int.Parse(txtCurrScore.Text), up);
            player[up].incrementDarts(3);
            statsSheet.addDarts(3, up);


            updateStats();
            updateGame();
            turn++;
            txtCurrScore.Clear();
            textBox1.Text = statsSheet.totalPoints[0].ToString();
        }

        public void updateStats()
        {
            int up = turn % numPlayers;
            statsSheet.calculateAverage(player[up].totPoints, player[up].dartsThrown, up);
            txtStats.Text = "Three Dart Average:"+ Environment.NewLine + statsSheet.average[up].ToString() + Environment.NewLine + "First Nine Average:" + Environment.NewLine + 
                statsSheet.average[up].ToString() + Environment.NewLine + "Last Score:" + Environment.NewLine + txtCurrScore.Text + Environment.NewLine +
                "Darts Thrown:" + Environment.NewLine + player[up].dartsThrown;
        }
    }
}
