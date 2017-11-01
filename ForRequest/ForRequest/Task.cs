using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace ForRequest
{
    class Task
    {
        public string question;
        public string answer;
       

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
