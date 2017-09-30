using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{
    class WrongAnswers
    {
        public string WrongAnswer;
        public WrongAnswers()
        { }

        public WrongAnswers(string Answer)
        {
            this.WrongAnswer = Answer;
        }

        public void ShowResult()
        {
            Console.WriteLine("You lose 100 points!");
        }
    }
    class WrongAnswerbyoneletter
    {
        public string WrongOneLetter;
        public WrongAnswerbyoneletter()
        { }

        public WrongAnswerbyoneletter(string WrongOneLetterAnswer)
        {
            this.WrongOneLetter = WrongOneLetterAnswer;
        }

        public void ShowResult()
        {
            Console.WriteLine("You lose 1 point!");
        }
    }
    class Wrongletter
    {
        public string WrongLetterAnswer;
        public Wrongletter()
        { }

        public Wrongletter(string WrongLetterAnswer)
        {
            this.WrongLetterAnswer = WrongLetterAnswer;
        }

        public void ShowResult()
        {
            Console.WriteLine("This letter does not exist in word!!");
        }
    }
}
