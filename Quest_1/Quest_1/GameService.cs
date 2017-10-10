using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    public interface GameService
    {
        GameView gameView { get; set; }
        TaskProvider taskProvider { get; set; }
        void guessWord(String word);
        void guessLetter(String letter);
        void start();
    }
}
