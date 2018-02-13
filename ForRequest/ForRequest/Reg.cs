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
    public partial class Reg : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Reg()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb;
Persist Security Info=False;";
        }
        //DataTable dt;

        private void button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbCommand command = new OleDbCommand();
                DateTime thisDay = DateTime.Today; // ПЕРЕВІРКА АКТУАЛЬНОСТІ ПО ДАТІ
                if (dateTimePicker_YearOfBirthday.Value.Date > thisDay || textBox_Password.Text != textBox_ConfrimPassword.Text)
                {
                    MessageBox.Show("Invalid data");
                }
                else
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "insert into Users (Username,UserPassword,FirstName,LastName,YearOfBirth,Gender) values('" + textBox_Username.Text + "','" + textBox_Password.Text + "', '" + textBox_FirstName.Text + "', '" + textBox_LastName.Text + "', '" + dateTimePicker_YearOfBirthday.Value.Date + "', '" + comboBox_Gender.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Реєстрація успішно завершена");
                    connection.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            
        }
    }
}