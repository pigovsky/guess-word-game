﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForRequest
{
    public class Task
    {
        public string question;
        public string answer;

        /* public override string ToString()
         {
             return String.Format("{0}: {1}", question, answer);
         } */

        public string GetQuestion()
        {
            return String.Format(question);
        }

        public string GetAnswer()
        {
            return String.Format(answer);
        }
    }
}
