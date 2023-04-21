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
using System.Windows.Forms.VisualStyles;

namespace Dart_Scorer
{
    public partial class Game : Form
    {
        public int startScore;
        public int numPlayers;
        public string[] names;
        public int turn = 0;
        Player[] player;
        Computer computer;
        private bool computerGame;
        
        StatsSheet statsSheet = new StatsSheet();
        public Game(int score, int num, string[] n, bool comp, int compdif)
        {
            InitializeComponent();
            startScore = score;
            numPlayers = num;
            computerGame = comp;
            player = new Player[numPlayers];
            for(int i = 0; i < numPlayers; i++)
            {
                player[i] = new Player(n[i], score);
            }
            if (comp)
            {
                computer = new Computer(compdif, score);
            }
            gameSetup();
        }

        

        public void gameSetup()
        { 
            txtCurrPlayer.Text = player[0].name;
            txtScore.Text = player[0].getScore().ToString();
            txtPlayerList.Clear();
            updateGame();
        }

        public void updateGame()
        {
            int upnext = (turn + 1) % numPlayers;
            txtCurrPlayer.Text = player[upnext].name;
            txtScore.Text = player[upnext].getScore().ToString();
            txtPlayerList.Clear();
            for (int i = 0; i < numPlayers; i++)
            {
                txtPlayerList.Text += player[i].name + ": " + player[i].getScore() + Environment.NewLine;
                txtPlayerList.Text += "Average: " + (float)Math.Round(statsSheet.average[i], 2) + Environment.NewLine + Environment.NewLine;
            }
            if(computerGame)
            {
                txtPlayerList.Text += computer.name + ": " + computer.getScore() + Environment.NewLine;
                txtPlayerList.Text += "Average: " + (float)Math.Round(statsSheet.caverage, 2) + Environment.NewLine + Environment.NewLine;
            }
        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            int currScore = int.Parse(txtCurrScore.Text);

            if (currScore < 0 || currScore > 180)
                return;

            int up = turn % numPlayers;
            if (player[up].score - currScore >= 0)
            {
                player[up].decrementScore(currScore);
                statsSheet.addScore(currScore, up);
            }
            player[up].incrementDarts(3);
            statsSheet.addDarts(3, up);
            statsSheet.calculateAverage(up);

            txtCmp.Text += computer.calculateScore().ToString() + " ";

            updateGame();
            turn++;
            updateStats();
            txtLastScore.Text = "Last Score: " + txtCurrScore.Text;
            txtCurrScore.Clear();
            if (player[up].score == 0)
            {
                restartGame();
            }
        }

        public void updateStats()
        {
            int up = turn % numPlayers;
            txtStats.Text = player[up].name + " Match Stats:" + Environment.NewLine + "Three Dart Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[up], 2) 
                + Environment.NewLine + "First Nine Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[up], 2) + Environment.NewLine + "Total Points Scored: "
                + Environment.NewLine + statsSheet.totalPoints[up] + Environment.NewLine +"Darts Thrown:" + Environment.NewLine + statsSheet.totalDarts[up];
        }

        private void txtCurrScore_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEnterScore.PerformClick();
            }
        }

        private void restartGame()
        {
            for (int i = 0; i < numPlayers; i++)
            {
                player[i].score = startScore;
                player[i].dartsThrown = 0;
            }
            turn = 0;
            updateGame();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }
    }
}
