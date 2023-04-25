using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DartScorer.Untitled;


namespace Dart_Scorer
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            String username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            user = readData(username, password);

            try
            {

                if(user == null)
                {
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
                }
                else
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    txtUsername.Clear();
                    txtPassword.Clear();

                    Match form2 = new Match(user.username);
                    form2.Show();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUp form3 = new SignUp();
            form3.Show();
            this.Hide();
        }

        public User readData(string usr, string pass)
        {
            string file = "C:\\Users\\Chase\\Source\\Repos\\Dart-Scorer\\Dart Scorer\\db.txt";
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int currentLineNum = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == usr && parts[1] == pass)
                        {
                            User user = new User(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            return user;
                        }
                        currentLineNum++;
                    }
                }
            }
            return null;
        }
    }
}
