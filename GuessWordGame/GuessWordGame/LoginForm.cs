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
using MetroFramework.Components;

namespace GuessWordGame
{
    public interface ILoginForm
    {
        string Login { get; }
        string Password { get; }
        void Showw();
        void Hidee();
        event EventHandler LogIn;
        event EventHandler SignUp;
    }
    public partial class LoginForm : MetroForm, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Login
        {
            get
            {
                return lblLogin.Text;
            }
        }

        public string Password
        {
            get
            {
                return lblPassword.Text;
            }
        }

        public event EventHandler LogIn;
        public event EventHandler SignUp;

        private void btLogIn_Click(object sender, EventArgs e)
        {
            LogIn?.Invoke(this, EventArgs.Empty);
        }

        public void Showw()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
            this.Show();
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
        public void Hidee()
        {
            this.Hide();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp(this, EventArgs.Empty);
        }
    }
}
