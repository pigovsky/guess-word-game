using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_word_game
{
     public class Task
    {
       public string answer;
       public string question;

        public override string ToString()
        {
            return String.Format("{0} {1}", question, answer);
        }

        public override bool Equals(object obj)
        {
            var a = (obj as Task);
            return a.answer == answer && a.question == question;
        }
    }
}
