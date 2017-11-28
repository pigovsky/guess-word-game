using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_lab_
{
    public class GameServiceImpl : GameService
    {
        public GameView gameView { get; set; }
        public TaskProvider taskProvider { get; set; }
        public GameServiceImpl(GameView _gameView, TaskProvider _taskProvider)
        {
            this.gameView = _gameView;
            this.taskProvider = _taskProvider;
        }
        public void guessWord(String word)
        {
            if (word != "")
            {
                if (taskProvider.get().Answer == word)
                    gameView.showCongratulations("Ви вгадали слово!");
                else
                    gameView.showSorry("Неправильна відповідь");
            }
            else
                gameView.showSorry("Віповідь не може бути пустою стрічкою");
        }
        public void guessLetter(String letter)
        {
            if (letter != "")
            {
                if (taskProvider.get().Answer.IndexOf(letter) != -1)
                    gameView.showCongratulations("Ви вгадали букву");
                else
                    gameView.showSorry("Відповідь не містить такої букви");
            }
            else
                gameView.showSorry("Віповідь не може бути пустою стрічкою");
        }
        public void start()
        {
            gameView.showTask(taskProvider.get());
        }
    }
}
