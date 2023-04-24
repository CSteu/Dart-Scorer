using System;
using System.IO;
using System.Windows.Forms;

namespace Dart_Scorer
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"db.txt");
            string olddata = sr.ReadLine();
            sr.Close();
            string[] data = new string[3];
            data[0] = txtUsername.Text;
            data[1] = txtPassword.Text;
            data[2] = txtNickname.Text;
            StreamWriter sw = new StreamWriter(@"db.txt");

            sw.Write(olddata + (Environment.NewLine) + "user=" + data[0] + ",pass=" + data[1] + ",nick=" + data[2]);


            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
