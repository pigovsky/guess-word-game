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
    public partial class Form1 : Form
    {
        #region Fields
        string TempStar;
        string CheckStar;
        string Answer;
        int Score = 0;
        private List<Task> tasks;
        Random rnd = new Random();
        #endregion 

        public enum Statuses
        {
            Wrong = 0,
            Right = 1,
            AlreadyOpened = 2
        }

        public void GetNewQuestion()
        {
            int number = rnd.Next(tasks.Count);
            var task = tasks[number];
            if (tasks.Count == 0)
            {
                MessageBox.Show("Ви завершили гру");
                Environment.Exit(0);
            }
            tasks.Remove(task);
            label1.Text = task.GetQuestion();
            Answer = task.GetAnswer();
            Answer = Answer.ToLower();

            TempStar = "";
            for (int i = 0; i < Answer.Length; i++)
            {
                TempStar = TempStar + "*";
            }
            label2.Text = TempStar;
            CheckStar = TempStar;
        }

        public Form1()
        {

            InitializeComponent();

            string url = "https://raw.githubusercontent.com/pigovsky/guess-word-game/master/tasks/all.json";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                var json = new StreamReader(resStream).ReadToEnd();
                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

            GetNewQuestion();


        }

        #region CheckMethods
        public void CheckSingleLetter(char input)
        {
            Statuses Status = Statuses.Wrong;
            for (int i = 0; i < Answer.Length; i++)
            {
                if (Answer[i] == input && TempStar[i] == '*')
                {
                    TempStar = TempStar.Remove(i, 1).Insert(i, input.ToString());
                    Status = Statuses.Right;
                }
                else if (Answer[i] == input && TempStar[i] == input)
                {
                    Status = Statuses.AlreadyOpened;
                }
            }
            if (Status == Statuses.Wrong)
            {
                ShowNotification("Введена буква невірна", Color.Yellow);
                Score = Score - 5;
            }
            if (Status == Statuses.Right)
            {
                ShowNotification("Введена буква вірна", Color.Green);
                Score = Score + 5;
                CheckWinCondition();
            }
            if (Status == Statuses.AlreadyOpened)
            {
                ShowNotification("Ця буква уже відкрита", Color.Yellow);
            }
        }
        public void CheckFullWord(string input)
        {
            if (input == Answer && CheckStar == TempStar)
            {
                TempStar = Answer;
                ShowNotification("Вітаю. Ви вгадали слово", Color.Green);
                Score = Score + 100;
                GetNewQuestion();
            }
            else if (input == Answer && CheckStar != TempStar)
            {
                ShowNotification("Слово вірне", Color.Green);
                for (int i = 0; i < Answer.Length; i++)
                {
                    if (TempStar[i] == CheckStar[i])
                    {
                        Score = Score + 5;
                    }
                }
                TempStar = Answer;
                GetNewQuestion();
            }
            else if (input != Answer && input.Length == Answer.Length)
            {
                ShowNotification("Ви не вгадали слово", Color.Red);
                Score = Score - 100;
            }
        }
        public void CheckFewLetters(string input)
        {
            int counter = 0;
            for (int i = 0; i < Answer.Length - input.Length + 1; i++)
            {
                if (Answer.Substring(i, input.Length) == input && TempStar.Substring(i, input.Length) == CheckStar.Substring(i, input.Length))
                {
                    TempStar = TempStar.Substring(0, i) + input + TempStar.Substring(i + input.Length);

                    counter++;
                }
            }
            if (counter > 0)
            {
                ShowNotification("Ви вгадали декілька букв", Color.Green);
                Score = Score + input.Length * 5 + 5;
            }
            else
            {
                ShowNotification("Ви не вгадали декілька букв", Color.Yellow);
                Score = Score + input.Length * -5 - 5;
            }

            CheckWinCondition();
        }
        public void CheckWinCondition()
        {
            if (TempStar == Answer)
            {
                ShowNotification("Вітаю. Ви вгадали слово", Color.Green);
                GetNewQuestion();
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToLower();

            if (input.Length == 1) // ДЛЯ ОДНОГО СИМВОЛА
            {
                CheckSingleLetter(Convert.ToChar(input));
            }
            else if (input.Length == Answer.Length) // ЦІЛЕ СЛОВО
            {
                CheckFullWord(input);
            }
            else if (input.Length > 1) // ДЛЯ ДЕКІЛЬКОХ СИМВОЛІВ 
            {
                CheckFewLetters(input);
            }
            else // ЯКЩО НІЧОГО НЕ ВВЕДЕНО
            {
                ShowNotification("Введіть символ або слово", Color.Yellow);
            }

            label2.Text = TempStar.ToUpper();
            textBox1.Clear();
            label2.Text = $"{TempStar[0].ToString().ToUpper()}{TempStar.Substring(1, TempStar.Length - 1)}";
            label3.Text = "Score: " + Convert.ToString(Score);
        }

        private void ShowNotification(string message, Color color)
        {
            label4.Text = message;
            label4.BackColor = color;
        }
    }
}