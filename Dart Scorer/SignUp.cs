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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R2CKJ5T;Initial Catalog=DartScorer;Integrated Security=True");

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "insert into Login values('" + txtUsername.Text + "','" + txtPassword.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
