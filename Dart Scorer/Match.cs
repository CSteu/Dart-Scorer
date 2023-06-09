﻿using System;
using System.Windows.Forms;
using DartScorer.Untitled;

namespace Dart_Scorer
{
    public partial class Match : Form
    {
        string[] names = new string[4];
        User user1 = new User();
        private int startScore;
        private int bestOf;
        private string user;
        public Match(string user)
        {
            InitializeComponent();
            //panelHomeScreen.Hide();
            panelStatsScreen.Hide();
            txtPlayer2.Hide();
            txtPlayer3.Hide();
            txtPlayer4.Hide();
            txtDartbot.Hide();
            this.user = user;
            setUser();
            dartbotLabel.Visible = false;
            upDownSkillLevel.Visible = false;
        }

        private void setUser()
        {
            user1 = user1.getStats(user);
            txtPlayer1.Text = user1.nickname;
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            readNames();
            checkSettings();
            Game form1 = new Game(startScore, (int)playerUpDown.Value, names, computerCheck.Checked, (int)upDownSkillLevel.Value, bestOf, user);
            form1.Show();
            this.Close();
        }

        private void playerUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (playerUpDown.Value == 1)
            {
                txtPlayer1.Show();
                txtPlayer2.Hide();
                txtPlayer3.Hide();
                txtPlayer4.Hide();
            }
            else if (playerUpDown.Value == 2)
            {
                txtPlayer1.Show();
                txtPlayer2.Show();
                txtPlayer3.Hide();
                txtPlayer4.Hide();
            }
            else if (playerUpDown.Value == 3)
            {
                txtPlayer1.Show();
                txtPlayer2.Show();
                txtPlayer3.Show();
                txtPlayer4.Hide();
            }
            else if (playerUpDown.Value == 4)
            {
                txtPlayer1.Show();
                txtPlayer2.Show();
                txtPlayer3.Show();
                txtPlayer4.Show();
            }
        }

        public void readNames()
        {
            names[0] = txtPlayer1.Text;
            names[1] = txtPlayer2.Text;
            names[2] = txtPlayer3.Text;
            names[3] = txtPlayer4.Text;
        }

        public void checkSettings()
        {
            if (rb301.Checked)
            {
                startScore = 301;
            }
            else if (rb501.Checked)
            {
                startScore = 501;
            }
            else if (rb701.Checked)
            {
                startScore = 701;
            }

            if (rb1leg.Checked)
            {
                bestOf = 1;
            }
            else if (rb3leg.Checked)
            {
                bestOf = 2;
            }
            else if (rb5leg.Checked)
            {
                bestOf = 3;
            }
        }

        private void computerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (computerCheck.Checked)
            {
                playerUpDown.Value = 1;
                playerUpDown.Hide();
                playerUpDown_ValueChanged(sender, e);
                txtDartbot.Show();
                dartbotLabel.Visible = true;
                upDownSkillLevel.Visible = true;
            }
            else
            {
                playerUpDown.Show();
                txtDartbot.Hide();
                dartbotLabel.Visible = false;
                upDownSkillLevel.Visible = false;
            }
        }
        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //panelHomeScreen.Show();
            panelMatchScreen.Show();
            panelStatsScreen.Hide();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
           // panelHomeScreen.Hide();
            panelMatchScreen.Show();
            panelStatsScreen.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
           //panelHomeScreen.Show();
            panelMatchScreen.Show();
            panelStatsScreen.Show();
            updateStatsScreen();
        }

        private void updateStatsScreen()
        {
            txtStats.Clear();
            decimal average;
            if (user1.totDarts == 0)
                average = 0;
            else
                average = (decimal)user1.totPoints / user1.totDarts;
            labelStatsScreen.Text = user1.nickname + "'s Stats " + Environment.NewLine;
            txtStats.Text += "PPR: " + Math.Round(average, 2) * 3 + Environment.NewLine;
            txtStats.Text += "PPD: " + Math.Round(average, 2) + Environment.NewLine;
            txtStats.Text += "Total Points: " + user1.totPoints + Environment.NewLine;
            txtStats.Text += "Total Darts: " + user1.totDarts + Environment.NewLine;
            txtStats.Text += "Matches Played: " + user1.matchesPlayed + Environment.NewLine;
        }

        private void dartbotLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
