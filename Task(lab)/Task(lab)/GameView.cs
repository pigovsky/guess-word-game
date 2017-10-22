using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_lab_
{
    public interface GameView
    {
        void showSorry(string Message);
        void showCongratulations(string message);
        void showCurrentGuess(String guess);
        void showTask(Task task);
    }
}
