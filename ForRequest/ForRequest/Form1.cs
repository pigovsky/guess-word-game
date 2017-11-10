using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ForRequest
{
    public partial class Form1 : Form, IGameView
    {
        /*string TempStar;
        string CheckStar;
        string Answer;
        int Score = 0;*/
        GameLogic gameLogic;

        public void ShowGameOver()
        {
            MessageBox.Show("Ви завершили гру");
        }

        public void ShowQuestion(Task task)
        {
            label1.Text = task.GetQuestion();
        }

        public void ShowAnswer(string TempStar)
        {
            textBox1.Clear();
            label2.Text = $"{TempStar[0].ToString().ToUpper()}{TempStar.Substring(1, TempStar.Length - 1)}";
            
        }

        public void ShowScore(int Score)
        {
            label3.Text = "Score: " + Convert.ToString(Score);
        }

        public Form1()
        {
            InitializeComponent();
            gameLogic = new GameLogic(this);
            gameLogic.Start();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            gameLogic.CheckAnswer(input);
        }

        public void ShowNotification(string message, Color color)
        {
            label4.Text = message;
            label4.BackColor = color;
        }
    }
}