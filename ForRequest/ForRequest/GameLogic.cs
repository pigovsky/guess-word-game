using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ForRequest
{
    class GameLogic
    {
        string TempStar;
        string CheckStar;
        string Answer;
        int Score = 0;

        IGameView gameView;

        public GameLogic(IGameView gameView)
        {
            this.gameView = gameView;
        }

        public void Start()
        {
            QuestionProvider questionProvider = new QuestionProvider();

            
            var task = questionProvider.Question();

            if (task == null)
            {
                gameView.ShowGameOver();
                Environment.Exit(0);
            }


            gameView.ShowQuestion(task);
            Answer = task.GetAnswer();
            Answer = Answer.ToLower();

            TempStar = "";
            for (int i = 0; i < Answer.Length; i++)
            {
                TempStar = TempStar + "*";
            }
            gameView.ShowAnswer(TempStar);
            CheckStar = TempStar;
        }
        public void CheckAnswer(string input)
        {
            
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
                gameView.ShowNotification("Введіть символ або слово", Color.Yellow);
            }

            gameView.ShowAnswer(TempStar);
            gameView.ShowScore(Score);
        }

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
                gameView.ShowNotification("Введена буква невірна", Color.Yellow);
                Score = Score - 5;
            }
            if (Status == Statuses.Right)
            {
                gameView.ShowNotification("Введена буква вірна", Color.Green);
                Score = Score + 5;
                CheckWinCondition();
            }
            if (Status == Statuses.AlreadyOpened)
            {
                gameView.ShowNotification("Ця буква уже відкрита", Color.Yellow);
            }
        }

        public void CheckFullWord(string input)
        {
            if (input == Answer && CheckStar == TempStar)
            {
                TempStar = Answer;
                gameView.ShowNotification("Вітаю. Ви вгадали слово", Color.Green);
                Score = Score + 100;
                Start();
            }
            else if (input == Answer && CheckStar != TempStar)
            {
                gameView.ShowNotification("Слово вірне", Color.Green);
                for (int i = 0; i < Answer.Length; i++)
                {
                    if (TempStar[i] == CheckStar[i])
                    {
                        Score = Score + 5;
                    }
                }
                TempStar = Answer;
                Start();
            }
            else if (input != Answer && input.Length == Answer.Length)
            {
                gameView.ShowNotification("Ви не вгадали слово", Color.Red);
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
                gameView.ShowNotification("Ви вгадали декілька букв", Color.Green);
                Score = Score + input.Length * 5 + 5;
            }
            else
            {
                gameView.ShowNotification("Ви не вгадали декілька букв", Color.Yellow);
                Score = Score + input.Length * -5 - 5;
            }

            CheckWinCondition();
        }

        public void CheckWinCondition()
        {
            if (TempStar == Answer)
            {
                gameView.ShowNotification("Вітаю. Ви вгадали слово", Color.Green);
                Start();
            }
        }
             
    }
}
