using DartScorer.Untitled;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dart_Scorer
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPassword.Text, txtNickname.Text, 0, 0, 0);
            user.writeData();

            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
