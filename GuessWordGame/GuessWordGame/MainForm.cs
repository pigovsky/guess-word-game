using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWordGame
{
    public interface IMainForm
    {
        string InputWord { get; }
        string HalfWord { set; }
        string FirstLastLetter { set; }
        void setScore(int score);
        event EventHandler VerifyClick;
        event EventHandler HalfWordClick;
        event EventHandler FirstLastLetterClick;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string FirstLastLetter
        {
            set
            {
                lblPrompts.Text = "Перша і остання літери: " + value;
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
        }

        public event EventHandler FirstLastLetterClick;
        public event EventHandler HalfWordClick;
        public event EventHandler VerifyClick;

        public void setScore(int score)
        {
            lblScore.Text = score.ToString();
        }
    }
}
