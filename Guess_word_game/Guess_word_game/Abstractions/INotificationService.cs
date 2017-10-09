using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game.Abstractions
{
    public interface INotificationService
    {
        void PrintCongratulationPlus100();
        void PrintSorryMinus100();
        void PrintCongratulationsLetterGuessed(int lettersCount);
        void PrintSorryWrongLetter();
        void PrintSorryInvalidKey();
        void PrintSorryLetterIsAlreadyGuessed();
    }
}
