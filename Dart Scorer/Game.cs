using DartScorer.Untitled;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dart_Scorer
{
    public partial class Game : Form
    {
        public int startScore;
        public int numPlayers;
        public int totPlayers;
        public string[] names;
        public int firstTo;
        private string user;
        public int turn = 0;
        Player[] player;
        Computer computer;
        private bool computerGame;

        StatsSheet statsSheet = new StatsSheet();
        public Game(int score, int num, string[] n, bool comp, int compdif, int first, string user)
        {
            InitializeComponent();
            startScore = score;
            numPlayers = num;
            computerGame = comp;
            firstTo = first;
            this.user = user;
            player = new Player[numPlayers];
            for (int i = 0; i < numPlayers; i++)
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
            txtNextPlayer.Hide();
            btnContinue.Hide();
            labelWinner.Hide();
            int x = (firstTo * 2) - 1;
            txtLegs.Text = "Best of " + x + " Legs";
            totPlayers = numPlayers;
            if (computerGame)
            {
                totPlayers = 2;
            }

            if (numPlayers >= 1)
            {
                panelPlayer1.Show();
            }
            if (numPlayers >= 2)
            {
                panelPlayer2.Show();
            }
            else
            {
                panelPlayer2.Hide();
            }
            if (numPlayers >= 3)
            {
                panelPlayer3.Show();
            }
            else
            {
                panelPlayer3.Hide();
            }
            if (numPlayers >= 4)
            {
                panelPlayer4.Show();
            }
            else
            {
                panelPlayer4.Hide();
            }
            if (computerGame)
            {
                panelComputer.Show();
                panelPlayer2.Show();
            }
            else
            {
                panelComputer.Hide();
            }
            updateGame();
            updateStats(0);
        }

        public async void updateGame()
        {
            if (computerGame && turn > 0)
            {
                computer.incrementDarts(3);
                statsSheet.addDarts(3, 4);
                int computerScore = computer.calculateScore();
                statsSheet.addScore(computerScore, 4);
                statsSheet.calculateAverage(4);
                txtCurrScore.Text = computerScore.ToString();
                txtScore.Text = player[0].getScore().ToString();
                turn++;
                if (computer.score == 0)
                {
                    computer.incrementLegs();
                    restartGame();
                }
            }
            if (!computerGame)
            {
                int upnext = (turn) % totPlayers;
                txtCurrPlayer.Text = player[upnext].name;
                txtScore.Text = player[upnext].getScore().ToString();

                if (turn != 0 && !computerGame)
                {
                    txtNextPlayer.Show();
                    txtNextPlayer.Text = player[upnext].name + " UP NEXT";
                    await Task.Delay(2000);
                    txtNextPlayer.Hide();
                }
            }

            if (numPlayers >= 1)
            {
                txtPlayer1.Text = player[0].name + ": " + player[0].getScore() + Environment.NewLine +
                    "Average: " + (float)Math.Round(statsSheet.average[0], 2);
                txtPlayer1Score.Text = player[0].legs.ToString();
            }
            if (numPlayers >= 2)
            {
                txtPlayer2.Text = player[1].name + ": " + player[1].getScore() + Environment.NewLine +
                    "Average: " + (float)Math.Round(statsSheet.average[1], 2);
                txtPlayer2Score.Text = player[1].legs.ToString();
            }
            if (numPlayers >= 3)
            {
                txtPlayer3.Text = player[2].name + ": " + player[2].getScore() + Environment.NewLine +
                    "Average: " + (float)Math.Round(statsSheet.average[2], 2);
                txtPlayer3Score.Text = player[2].legs.ToString();
            }
            if (numPlayers >= 4)
            {
                txtPlayer4.Text = player[3].name + ": " + player[3].getScore() + Environment.NewLine +
                    "Average: " + (float)Math.Round(statsSheet.average[3], 2);
                txtPlayer4Score.Text = player[3].legs.ToString();
            }
            if (computerGame)
            {
                txtComputer.Text = computer.name + ": " + computer.getScore() + Environment.NewLine
                        + "Average: " + (float)Math.Round(statsSheet.average[4], 2);
                txtComputerScore.Text = computer.legs.ToString();
            }
        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            int currScore = int.Parse(txtCurrScore.Text);
            int up = turn % totPlayers;

            if (currScore < 0 || currScore > 180)
                return;
            if (computerGame)
            {
                player[0].decrementScore(currScore);
                statsSheet.addScore(currScore, 0);
                player[0].incrementDarts(3);
                statsSheet.addDarts(3, 0);
                statsSheet.calculateAverage(0);
                if (player[0].score == 0)
                {
                    player[0].incrementLegs();
                    restartGame();
                }
            }
            else
            {
                if (player[up].score - currScore >= 0)
                {
                    player[up].decrementScore(currScore);
                    statsSheet.addScore(currScore, up);
                }
                player[up].incrementDarts(3);
                statsSheet.addDarts(3, up);
                statsSheet.calculateAverage(up);
                if (player[up].score == 0)
                {
                    player[up].incrementLegs();
                    restartGame();
                }
            }

            turn++;
            updateGame();
            txtLastScore.Text = "Last Score: " + txtCurrScore.Text;
            txtCurrScore.Clear();

        }

        public async void updateStats(int x)
        {
            int up = x % numPlayers;
            if (!computerGame)
            {
                txtStats.Text = player[up].name + " Match Stats:" + Environment.NewLine + "Three Dart Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[up], 2)
                    + Environment.NewLine + "First Nine Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[up], 2) + Environment.NewLine + "Total Points Scored: "
                    + Environment.NewLine + statsSheet.totalPoints[up] + Environment.NewLine + "Darts Thrown:" + Environment.NewLine + statsSheet.totalDarts[up];
            }
            else
            {
                if (x % 2 == 0)
                {
                    txtStats.Text = player[0].name + " Match Stats:" + Environment.NewLine + "Three Dart Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[0], 2)
                        + Environment.NewLine + "First Nine Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[0], 2) + Environment.NewLine + "Total Points Scored: "
                        + Environment.NewLine + statsSheet.totalPoints[0] + Environment.NewLine + "Darts Thrown:" + Environment.NewLine + statsSheet.totalDarts[0];
                }
                else
                {
                    txtStats.Text = computer.name + " Match Stats:" + Environment.NewLine + "Three Dart Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[4], 2)
                        + Environment.NewLine + "First Nine Average:" + Environment.NewLine + (float)Math.Round(statsSheet.average[4], 2) + Environment.NewLine + "Total Points Scored: "
                        + Environment.NewLine + statsSheet.totalPoints[4] + Environment.NewLine + "Darts Thrown:" + Environment.NewLine + statsSheet.totalDarts[4];
                }
            }
            await Task.Delay(5000);
            x++;
            updateStats(x);
        }

        private void txtCurrScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
            if (computerGame)
            {
                if (computer.legs == firstTo)
                {
                    labelWinner.Show();
                    btnContinue.Show();
                    labelWinner.Text = computer.name + " Wins!" + Environment.NewLine +
                        player[0].legs + " - " + computer.legs; ;
                    updateUserStats();
                }
                else if (player[0].legs == firstTo)
                {
                    labelWinner.Show();
                    btnContinue.Show();
                    labelWinner.Text = player[0].name + " Wins!" + Environment.NewLine +
                        player[0].legs + " - " + computer.legs;
                    updateUserStats();
                }
                computer.score = startScore;
                computer.dartsThrown = 0;
            }
            else
            {
                int up = turn % totPlayers;
                if (player[up].legs == firstTo)
                {
                    labelWinner.Show();
                    btnContinue.Show();
                    labelWinner.Text = player[up].name + " Wins!";
                    updateUserStats();
                }
            }
            
            turn = 0;
            txtScore.Text = startScore.ToString();
            updateGame();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pbComputer_Click(object sender, EventArgs e)
        {

        }

        private void txtComputer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComputerScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            Match form1 = new Match(user);
            form1.Show();
            this.Close();
        }

        private void updateUserStats()
        {
            User user1 = new User();
            user1 = user1.getStats(user);
            int totPoints = user1.totPoints + statsSheet.totalPoints[0];
            int totDarts = user1.totDarts += statsSheet.totalDarts[0];
            int totMatches = user1.matchesPlayed + 1;
            user1.updateStats(user, totPoints, totDarts, totMatches);
        }
    }
}
