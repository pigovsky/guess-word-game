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
        int CurrentScore();
        void RaiseScorebyWord();
        void ReduceScorebyWord();
        void ReduceScorebyLetter();
        string GetWordbyLetter(char letter);
        string HalfOfWord();
        string LastAndFirst();
        string getTask();
        bool Auth(string Login,string Password);
        bool SignUp(string Surname, string Name,
                string Login, string Password, DateTime DateOfBirth,
                Sex sex, string EMail);
        string getName();
        User GetUser();
        bool Save(int id,string Surname, string Name,
                string Login, string Password, DateTime DateOfBirth,
                Sex sex, string EMail);


    }
    public class GuessManager : IGuessManager
    {
        User myAccount;
        private RegistryKey scoreControler = Registry.CurrentUser;
        private List<Task> items;
        private Task currentTask;
        private StringBuilder letters = new StringBuilder();
        UsersDaoSQLite UDSQL = new UsersDaoSQLite();
        public int CurrentScore()
        {
            return myAccount.score;
        }
        public string getName()
        {
            return myAccount.name;
        }
        public string getTask()
        {
            if (items == null)
            {
                string path = "task.json";
                using (StreamReader r = new StreamReader(path))
                {
                    string json2 = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<Task>>(json2);
                }
            }
            if(myAccount.currentQuestion == 11)
            {
                myAccount.currentQuestion = 1;
                myAccount = UDSQL.update(myAccount);
                return "WIN";
            }
            else
            {
                currentTask = items[(myAccount.currentQuestion)-1];
                myAccount = UDSQL.update(myAccount);
                return currentTask.Question;
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
            myAccount.score += 20;
            myAccount.currentQuestion += 1;
            myAccount = UDSQL.update(myAccount);
        }
        public void ReduceScorebyWord()
        {
            myAccount.score -= 10;
            myAccount = UDSQL.update(myAccount);
        }
        public void ReduceScorebyLetter()
        {
            myAccount.score -= 1;
            myAccount = UDSQL.update(myAccount);
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
        public bool Auth(string Login, string Password)
        {
            myAccount = UDSQL.findUser(Login, Password);
            if (myAccount != null)
                return true;
            else
                return false;
        }
        public bool SignUp(string Surname, string Name,
                string Login, string Password, DateTime DateOfBirth,
                Sex sex, string EMail)
        {
            if(UDSQL.findUser(Login)== null)
            {
                User newUser = new User();
                newUser.surname = Surname;
                newUser.name = Name;
                newUser.login = Login;
                newUser.passwordHash = Password;
                newUser.dateOfBirth = DateOfBirth;
                newUser.sex = sex;
                newUser.email = EMail;
                UDSQL.add(newUser);
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUser()
        {
            return myAccount;
        }

        public bool Save(int id,string Surname, string Name,
                string Login, string Password, DateTime DateOfBirth,
                Sex sex, string EMail)
        {
            if (myAccount.passwordHash == Password)
            {
                User newUser = new User();
                newUser.surname = Surname;
                newUser.name = Name;
                newUser.login = Login;
                newUser.passwordHash = Password;
                newUser.dateOfBirth = DateOfBirth;
                newUser.sex = sex;
                newUser.email = EMail;
                newUser.id = id;
                newUser.currentQuestion = myAccount.currentQuestion;
                newUser.score = myAccount.score;
                myAccount =  UDSQL.update(newUser);
                return true;
            }
            else return false;
        }
    }
}
