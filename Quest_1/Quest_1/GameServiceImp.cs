using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    public class GameServiceImp : GameService
    {
        public GameView gameView { get; set; }
        public TaskProvider taskProvider { get; set; }

        public GameServiceImp(GameView view, TaskProvider provider)
        {
            gameView = view;
            taskProvider = provider;
        }

        public void guessLetter(string letter)
        {
            gameView.showSorry("DDD");
        }

        public void guessWord(string word)
        {
            gameView.showTask(new Task());
        }

        public void start()
        {
            gameView.showCurrentGuess("RRR");
            gameView.showCongratulations("EEE");
        }
    }
}
