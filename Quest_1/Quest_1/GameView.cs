using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_1
{
    public interface GameView
    {
        void showSorry(string message);
        void showCongratulations(string message);
        void showCurrentGuess(string gues);
        void showTask(Task task);
    }
}
