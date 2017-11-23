using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessWordGame
{
    public struct Task
    {
        public Task(
            String question,
        String answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public String question;
        public String answer;
    }
}
