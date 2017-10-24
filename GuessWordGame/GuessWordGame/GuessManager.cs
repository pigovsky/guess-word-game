using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    public interface IGuessManager
    {
        bool GuessWord(string word);
        string GuessLetter(char letter);
        void FirstEntrance();
        int CurrentScore();

    }
    class GuessManager
    {
    }
}
