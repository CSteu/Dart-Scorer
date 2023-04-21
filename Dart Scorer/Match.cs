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
        public Match()
        {
            InitializeComponent();
            txtPlayer2.Hide();
            txtPlayer3.Hide();
            txtPlayer4.Hide();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            Game form1 = new Game(501, (int)playerUpDown.Value);
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
    }
}
