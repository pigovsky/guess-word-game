using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;

namespace GuessWordGame
{
    public interface IGuessManager
    {
        bool GuessWord(string word);
        bool GuessLetter(char letter);
        void FirstEntrance();
        int CurrentScore();
        void RaiseScorebyWord();
        void ReduceScorebyWord();
        void ReduceScorebyLetter();
        string GetWordbyLetter(char letter);
        string HalfOfWord();
        string LastAndFirst();
        string getTask();


    }
    public class GuessManager : IGuessManager
    {
        private RegistryKey scoreControler = Registry.CurrentUser;
        private int number_of_item = -1;
        private List<Task> items;
        private Task currentTask;
        private StringBuilder letters = new StringBuilder();
        public void FirstEntrance()
        {
            scoreControler = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\GuessWord\\");
            if (scoreControler == null)
            {
                scoreControler = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\GuessWord\\");
                scoreControler.SetValue("Score", "100");
                scoreControler.Close();
            }
            scoreControler.Close();
        }
        public int CurrentScore()
        {
            scoreControler = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\GuessWord\\");
            scoreControler.OpenSubKey(@"SOFTWARE\\GuessWord\\");
            int score =  Convert.ToInt32(scoreControler.GetValue("Score"));
            scoreControler.Close();
            return score;
        }
        public string getTask()
        {
            if (number_of_item == -1)
            {
                string path = "task.json";
                using (StreamReader r = new StreamReader(path))
                {
                    string json2 = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<Task>>(json2);
                }
            }
            number_of_item++;
            if (number_of_item > items.Count - 1)
                return null;
            else
            {
                currentTask = items[number_of_item];
                letters.Clear();
                for (int i = 0; i < currentTask.Answer.Length; i++)
                    letters.Append("*");
                return items[number_of_item].Question;
            }
        }
        public bool GuessWord(string word)
        {
            if (word.ToLower() == currentTask.Answer.ToLower())
                return true;
            else
                return false;
        }
        public bool GuessLetter(char letter)
        {
            if (currentTask.Answer.IndexOf(letter) != -1)
            {
                return true;
            }
            else
                return false;
        }
        public void RaiseScorebyWord()
        {
            scoreControler = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\GuessWord\\",true);
            int score = Convert.ToInt32(scoreControler.GetValue("Score"));
            score = score + 20;
            scoreControler.SetValue("Score",score.ToString());
            scoreControler.Close();
        }
        public void ReduceScorebyWord()
        {
            scoreControler = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\GuessWord\\", true);
            int score = Convert.ToInt32(scoreControler.GetValue("Score"));
            score = score - 10;
            scoreControler.SetValue("Score", score.ToString());
            scoreControler.Close();
        }
        public void ReduceScorebyLetter()
        {
            scoreControler = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\GuessWord\\", true);
            int score = Convert.ToInt32(scoreControler.GetValue("Score"));
            score = score - 1;
            scoreControler.SetValue("Score", score.ToString());
            scoreControler.Close();
        }
        public string GetWordbyLetter(char letter)
        {
            string answer = currentTask.Answer;
            char[] temp = letters.ToString().ToCharArray();
            for(int i = 0;i < answer.Length; i++)
            {
                if (letter.ToString().ToLower() == answer[i].ToString().ToLower())
                {
                    temp[i] = answer.ToCharArray()[i];
                }
            }
            letters.Clear();
            letters.AppendFormat(new string(temp));
            return letters.ToString();
        }
        public string HalfOfWord()
        {
            string answer = currentTask.Answer;
            string result = "";
            for (int i = 0; i < answer.Length/2; i++)
            {
                result += answer[i];
            }
            for(int i=0;i<5;i++)
            {
                ReduceScorebyWord();
            }
            return result;
        }
        public string LastAndFirst()
        {
            string answer = currentTask.Answer;
            string result = "";
            result += answer[0];
            result += answer[answer.Length - 1];
            for (int i = 0; i < 3; i++)
            {
                ReduceScorebyWord();
            }
            return result;
        }
        
    }
}
