using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{
    class Answers
    {
        public string Answer;
        public Answers()
        { }

        public Answers(string Answer)
        {
            this.Answer = Answer;
        }

        public void ShowResult()
        {
            Console.WriteLine("Congratulations you have got 100 points!");
        }
    }
    class Answerbyoneletter
    {
        public string OneLetterAnswer;
        public Answerbyoneletter()
        { }

        public Answerbyoneletter(string OneLetterAnswer)
        {
            this.OneLetterAnswer = OneLetterAnswer;
        }

        public void ShowResult()
        {
            Console.WriteLine("Congratulations you have got 1 points!");
        }
    }
}
