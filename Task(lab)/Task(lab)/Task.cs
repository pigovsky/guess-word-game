using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_lab_
{
    public struct Task
    {
        public string Question;
        public string Answer;
        public Task(string question, string answer)
        {
            Question = question;
            Answer =  answer;
        }
    }
}
