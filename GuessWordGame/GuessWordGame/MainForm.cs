using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace GuessWordGame
{
    public interface IMainForm
    {
        string InputWord { get; set; }
        string HalfWord { set; }
        string Letters { set; }
        string Question { set; }
        string FirstLastLetter { set; }
        void setScore(int score);
        int typeVerify { get; }
        void Vision();
        event EventHandler VerifyClick;
        event EventHandler HalfWordClick;
        event EventHandler FirstLastLetterClick;
        event EventHandler InformationClick;
        void SetWelcome(string name);
    }
    public partial class MainForm : MetroForm, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetWelcome(string name)
        {
            lblName.Text = "Вітаємо "+name;
        }
        public string FirstLastLetter
        {
            set
            {
                lblPrompts.Text = "Перша літера:"+value[0]+Environment.NewLine
                    + "Oстання літерa: " + value[1];
            }
        }

        public string HalfWord
        {
            set
            {
                lblPrompts.Text = "Половина слова: " + value;
            }
        }

        public string InputWord
        {
            get
            {
                return tboxGuessWord.Text;
            }
            set
            {
                tboxGuessWord.Text = value;
            }
        }

        public int typeVerify
        {
            get
            {
                if (rdGuessWord.Checked == true)
                    return 1;
                else
                    return 2;
            }
        }

        public string Question
        {
            set
            {
                lblQuestion.Text = value;
            }
        }

        public string Letters
        {
            set
            {
                lblPrompts.Text = value;
            }
        }


        public event EventHandler FirstLastLetterClick;
        public event EventHandler HalfWordClick;
        public event EventHandler VerifyClick;
        public event EventHandler InformationClick;
        public void Vision()
        {
            this.Show();
        }

        public void setScore(int score)
        {
            lblScore.Text = score.ToString();
        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            VerifyClick?.Invoke(this, EventArgs.Empty);
        }

        private void btHalfWord_Click(object sender, EventArgs e)
        {
            HalfWordClick?.Invoke(this, EventArgs.Empty);
        }

        private void btFirstLastLetters_Click(object sender, EventArgs e)
        {
            FirstLastLetterClick?.Invoke(this, EventArgs.Empty);
        }

        private void rdGuessWord_CheckedChanged(object sender, EventArgs e)
        {
            tboxGuessWord.Text = string.Empty;
            tboxGuessWord.MaxLength = 20;
        }

        private void rdGuessLetters_CheckedChanged(object sender, EventArgs e)
        {
            tboxGuessWord.Text = string.Empty;
            tboxGuessWord.MaxLength = 1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            InformationClick(this,EventArgs.Empty);
        }
    }
}
