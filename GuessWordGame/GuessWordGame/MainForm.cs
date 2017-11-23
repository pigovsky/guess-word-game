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
        event EventHandler VerifyClick;
        event EventHandler HalfWordClick;
        event EventHandler FirstLastLetterClick;
        event EventHandler MainFormLoad;
    }
    public partial class MainForm : MetroForm, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
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
        public event EventHandler MainFormLoad;

        public void setScore(int score)
        {
            lblScore.Text = score.ToString();
        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            if (VerifyClick != null) VerifyClick(this, EventArgs.Empty);
        }

        private void btHalfWord_Click(object sender, EventArgs e)
        {
            if (HalfWordClick != null) HalfWordClick(this, EventArgs.Empty);
        }

        private void btFirstLastLetters_Click(object sender, EventArgs e)
        {
            if (FirstLastLetterClick != null) FirstLastLetterClick(this, EventArgs.Empty);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (MainFormLoad != null) MainFormLoad(this, EventArgs.Empty);
        }
    }
}
