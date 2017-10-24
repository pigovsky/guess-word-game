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
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
