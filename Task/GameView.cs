using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessWordGame
{
    public interface GameView
    {
        void showSorry(string message);
        void showCongradulations(string message);
        void showCurrentGuess(string guess);
        void showTask(Task task);
    }
}
