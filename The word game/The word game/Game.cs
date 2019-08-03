using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{
    class Game
    {
        string currentGuess;
        GameTask task;
        TaskProvaider taskProvider;

        public Game(TaskProvaider taskProvider)
        {
            this.taskProvider = taskProvider;
        }
        void Start()
        {
            task = taskProvider.GetTask();
            currentGuess = new String('*', task.answer.Length);
            Console.WriteLine(currentGuess);
        }
        void GuessWord()
        {
          
        }

    }
}
