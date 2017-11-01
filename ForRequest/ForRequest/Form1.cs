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
        string TempStar;
        string Temp;
        int Score = 0;
        private List<Task> tasks;

        Random rnd = new Random();
        string CheckStar;

        public void Game()
        {
            int number = rnd.Next(tasks.Count);
            var task = tasks[number];
            tasks.Remove(task);
            if (tasks.Count == 0)
            {
                MessageBox.Show("Ви завершили гру");
            }
            label1.Text = task.GetQuestion();
            Temp = task.GetAnswer();
            Temp = Temp.ToLower();

            TempStar = "";
            for (int i = 0; i < Temp.Length; i++)
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

            Game();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToLower();

            if (input.Length == 1)
            {
                int counter = 0;
                for (int i = 0; i < Temp.Length; i++)
                {
                    if (Temp[i] == Convert.ToChar(input) && TempStar[i] == '*')
                    {
                        TempStar = TempStar.Remove(i, 1).Insert(i, input.ToString());
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    MessageBox.Show("Введена буква невірна");
                    Score = Score - 5;
                }
                else
                {
                    MessageBox.Show("Введена буква вірна");
                    Score = Score + 5;
                    if (TempStar == Temp)
                    {
                        MessageBox.Show("Вітаю. Ви вгадали слово");
                        Game();
                    }
                }
            }
            else if (input.Length > 1)
            {
                if (input == Temp && CheckStar == TempStar)
                {
                    TempStar = Temp;
                    MessageBox.Show("Вітаю. Ви вгадали слово");
                    Score = Score + 100;
                    Game();
                }
                else if (input == Temp && CheckStar != TempStar)
                {
                    MessageBox.Show("Слово вірне");
                    for (int i = 0; i < Temp.Length; i++)
                    {
                        if (TempStar[i] == CheckStar[i])
                        {
                            Score = Score + 5;
                        }
                    }
                    TempStar = Temp;
                    Game();
                }
                else
                {
                    MessageBox.Show("Ви не вгадали слово");
                    Score = Score - 100;
                }
            }
            else
            {
                MessageBox.Show("Введіть символ або слово");
            }

            label2.Text = TempStar.ToUpper();
            textBox1.Clear();
            label2.Text = $"{TempStar[0].ToString().ToUpper()}{TempStar.Substring(1, TempStar.Length - 1)}";
            label3.Text = "Score: " + Convert.ToString(Score);
        }
    }
}