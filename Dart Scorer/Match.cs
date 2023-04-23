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
    public partial class Match : Form
    {
        string[] names = new string[4];
        private int startScore;
        public Match()
        {
            InitializeComponent();
            txtPlayer2.Hide();
            txtPlayer3.Hide();
            txtPlayer4.Hide();
            txtDartbot.Hide();
            dartbotLabel.Visible = false;
            upDownSkillLevel.Visible = false;
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            readNames();
            checkSettings();
            Game form1 = new Game(startScore, (int)playerUpDown.Value, names, computerCheck.Checked, (int)upDownSkillLevel.Value);
            form1.Show();
            this.Close();
        }

        private void playerUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(playerUpDown.Value == 1)
            {
                txtPlayer1.Show();
                txtPlayer2.Hide();
                txtPlayer3.Hide();
                txtPlayer4.Hide();
            }
            else if(playerUpDown.Value == 2)
            {
                txtPlayer1.Show();
                txtPlayer2.Show();
                txtPlayer3.Hide();
                txtPlayer4.Hide();
            }
            else if(playerUpDown.Value == 3)
            {
                txtPlayer1.Show();
                txtPlayer2.Show();
                txtPlayer3.Show();
                txtPlayer4.Hide();
            }
            else if(playerUpDown.Value == 4)
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
            else
            {
                startScore = 701;
            }

        }

        private void computerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(computerCheck.Checked)
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
    }
}
