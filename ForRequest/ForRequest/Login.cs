using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ForRequest
{
     public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb;
Persist Security Info=False;";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection to base successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //string test = "select * from Users where username = :0 AND password = :1";
            command.CommandText = "select * from Users where Username='" + txt_Username.Text + "' and UserPassword='" + txt_Password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();

            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate Username and password is correct");
            }
            else
            {
                MessageBox.Show("Username and password is not correct");
            }
            connection.Close();
        }

        private void button_NewUser_Click(object sender, EventArgs e)
        {
            Reg Reg = new Reg();
            Reg.ShowDialog();
        }
    }
}
