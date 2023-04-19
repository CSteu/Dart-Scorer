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


namespace Dart_Scorer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R2CKJ5T;Initial Catalog=DartScorer;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0 )
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    Match form2 = new Match();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp form3 = new SignUp();
            form3.Show();
            this.Hide();
        }
    }
}
