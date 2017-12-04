using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game
{
    class Game
    {
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        public int score = 0;
        public int round = 0;
        public int curentQuestion= 0;
        public  List<int> usedQuestion = new List<int>();
        public void StringSplitter()
        {
           
            StreamReader data = new StreamReader("C:\\Users\\irysa\\Desktop\\questions.txt");
            string line;
            string[] temp;
            while (!data.EndOfStream)
            {
                line = data.ReadLine();
                temp = line.Split('/');
                questions.Add(temp[0]);
                answers.Add(temp[1]);
            }

        }

        public int GetSize()
        {
            return questions.Count;
        }

        public string GetQuestion(int num)
        {
             return questions[num]; 
        }

        public string  GetAnsver( int num )
        {
            return answers[num];
        }
    }
}
