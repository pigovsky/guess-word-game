using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessWordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskProviderImpl value = new TaskProviderImpl();
            value.QuestionFromFile();



        }
    }
}
