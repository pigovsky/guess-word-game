using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace guess_word
{
    class Game
    {
        List<Container> tasks;

        public string UserName
        {
            get;
            private set;
        }

        public int Score
        {
            get;
            private set;
        }


        public void QuestInit()
        {
            StreamReader data = new StreamReader("tests.txt");
            string ask;
            while (!data.EndOfStream)
            {
                ask = data.ReadLine();
                tasks.Add(new Container(ask.Split('-')));
            }
        }

        public void Start()
        {
            Console.Write("\nВведіть ім'я :");
            UserName = Console.ReadLine();
            int numOfRound = 0;
            while (numOfRound < 10)
            {
                numOfRound++;
                Console.Write("\nЗапитання {0} з 10 :\n",numOfRound);
                Round();
            }
            End();
        }

        public void Round()
        {
            Random rand = new Random();
            int set = rand.Next(0,tasks.Count);
            Console.Write("Столиця {0}: ",tasks[set].Quest);
            if (tasks[set].Answer == Console.ReadLine())
            {
                Score += 100;
            }
            else
            {
                Score -= 100;
            }
        }

        public void End()
        {
            Console.WriteLine("\nГравець {0}", UserName);
            Console.WriteLine("Ваш рахунок :{0}",Score);
        }

        public Game()
        {
            tasks = new List<Container>();
            QuestInit();
        }
    }
}
