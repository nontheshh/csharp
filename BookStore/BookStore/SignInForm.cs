using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace BookStore
{
    public partial class SignInForm : Form
    {
        public string sqlString { get; set; }
        SqlConnection conn;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            sqlString =
                 $@"data source=.\sqlexpress;
                 initial catalog=BookStore;
                 user id={textLogin.Text};password={textPassword.Text}";

            if (allCorrect()) DialogResult = DialogResult.OK;
        }

        private void buttonWindowsSecurity_Click(object sender, EventArgs e)
        {
            sqlString = @"data source=.\sqlexpress;
                 initial catalog=BookStore;
                 integrated security=True;";

            if (allCorrect()) DialogResult = DialogResult.OK;
        }

        bool allCorrect()
        {
            using (conn = new SqlConnection(sqlString))
            {
                try
                {
                    conn.Query(@"select top(1) [Id] from [BookSet]");
                }
                catch
                {
                    MessageBox.Show("Login or Password is Incorrect");
                    return false;
                }
                return true;
            }
        }
    }
}