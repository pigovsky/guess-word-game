using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Text.RegularExpressions;

namespace GuessWordGame
{
    public interface IRegistrationForm
    {
        string Surname { get; }
        string MyName { get; }
        string Login { get; }
        string EMail { get; }
        DateTime DateOfBirth { get; }
        Sex sex { get; }
        string Password { get; }
        event EventHandler SignUp;
        void Showw();
        void Hidee();
    }
    public partial class RegistrationForm : MetroForm,IRegistrationForm
    {
        public event EventHandler SignUp;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public DateTime DateOfBirth
        {
            get
            {
                try
                {
                    if(Convert.ToInt32(tbYear.Text) < 1950)
                        throw new Exception("Введіть корректну дату народження вигляду: день - місяць - рік");
                    DateTime date = new DateTime(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text), Convert.ToInt32(tbDay.Text));

                    return date;
                }
                catch
                {
                    throw new Exception("Введіть корректну дату народження вигляду: день - місяць - рік");
                }
                
            }
        }

        public string EMail
        {
            get
            {
                Regex login_regex = new Regex(@"^([a-z0-9_\.-]+)@([a-z0-9_\.-]+)\.([a-z\.]{2,6})$");

                if (login_regex.Match(tbEMail.Text).Success)
                {
                    return tbEMail.Text;
                }
                else
                {
                    throw new Exception("Email має бути вигляду логін@піддомен.домен. Логін, як і піддомен - слова з букв, цифр, підкреслення, дефісів і крапок. А домен (мається на увазі 1-го рівня) - це від 2 до 6 букв і крапок");
                }
            }
        }

        public string Login
        {
            get
            {
                Regex login_regex = new Regex(@"^[\w_-]{3,16}$");

                if (login_regex.Match(tbLogin.Text).Success)
                {
                    return tbLogin.Text;
                }
                else
                {
                    throw new Exception("Логін має складатись з букв, цифр, дефіса та підкреслення, від 3 до 16 символів.");
                }
            }
        }

        public string Password
        {
            get
            {
                if(tbPassword.Text == "false")
                    throw new Exception("Пароль не може бути false");
                Regex login_regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{6,18}$");

                if (login_regex.Match(tbPassword.Text).Success) 
                {
                    return PasswordUtils.MD5(tbPassword.Text);
                }
                else
                {
                    throw new Exception("Пароль має складатись з латинських букв, цифр, від 6 до 18 символів.");
                }
            }
        }

        public Sex sex
        {
            get
            {
                if (cbSex.SelectedItem == null)
                    throw new Exception("Виберіть стать");
                else
                {
                    string str = cbSex.SelectedItem.ToString();
                    if (str == "Чоловіча")
                        return Sex.Female;
                    else
                        return Sex.Male;
                }
            }
        }

        public string Surname
        {
            get
            {
                Regex login_regex = new Regex(@"^[a-zA-Zа-яА-ЯІі]{1,30}$");

                if (login_regex.Match(tbSurname.Text).Success)
                {
                    return tbSurname.Text; 
                }
                else
                {
                    throw new Exception("Введіть коректне прізвище");
                }

            }
        }
        public string MyName
        {
            get
            {
                Regex login_regex = new Regex(@"^[a-zA-Zа-яА-ЯІі]{1,30}$");

                if (login_regex.Match(tbName.Text).Success)
                {
                    return tbName.Text;
                }
                else
                {
                    throw new Exception("Введіть коректне ім'я");
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SignUp?.Invoke(this, EventArgs.Empty);
        }

        public void Showw()
        {
            foreach (Control c in Controls)
                if (c is MetroTextBox)
                    ((MetroTextBox)c).Text = null;
            this.Show();
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
        public void Hidee()
        {
            this.Hide();
        }
    }
}
