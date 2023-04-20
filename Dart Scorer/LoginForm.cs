using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dart_Scorer
{
    public class LoginForm : Form
    {
        public LoginForm()
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // TODO: Check the user's credentials against a database or other authentication mechanism

            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
