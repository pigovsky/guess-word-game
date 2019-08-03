using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace The_word_game
{

    class Program
    {

        TaskProvaider TaskProvaider = new TaskProvaider();
        

        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run() { 
            string Score_path = @"Score.data";
            string Gamerules = @"Readme.md";
            string Usernickname = @"Nickname.txt";
            string Nickname = "";
            string GameAnswer;
            string Answer = "";
            string WrongAnswer = "";
            int Uscore = 0;
            bool exit = false;


            int i;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to my word game!");
                Console.WriteLine("Ok, what's your name?");
                using (StreamWriter sp = new StreamWriter(Usernickname, false, System.Text.Encoding.Default))
                {
                    Nickname = Console.ReadLine();
                    sp.WriteLine(Nickname);
                }
                Console.Clear();
                InfoClass nickname = new InfoClass(Nickname);
                nickname.Info();
                Console.Write("Меню:\n1) New game \n2) Scores \n3) Rules \n4) Exit \n\nEnter: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        int ic;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ok, " + Nickname + ". Here your first question: ");

                            var task = TaskProvaider.GetTask();
                            if( task == null)
                            {
                                Console.WriteLine("Game over");
                                using (System.IO.StreamWriter file = new StreamWriter(Score_path, true, Encoding.Default))
                                {
                                    file.WriteLine(Nickname + " got " + Uscore + " points");
                                }
                                return;
                            }
                            Console.WriteLine(task.question);
                            Console.WriteLine("Current guess {0}", currentGuess);

                            Console.Write("Меню:\n1) Give a full answer \n2) One letter answer \n3) Exit \n\nEnter: ");
                            ic = int.Parse(Console.ReadLine());
                            switch (ic)
                            {
                                case 1:
                                    
                                    Console.WriteLine("Enter answer: ");
                                    GameAnswer = Console.ReadLine();
                                    if(GameAnswer == task.answer)
                                    {
                                        Answers gameanswer = new Answers(Answer);
                                        gameanswer.ShowResult();
                                        Uscore = 100;
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        WrongAnswers gameanswer = new WrongAnswers(WrongAnswer);
                                        gameanswer.ShowResult();
                                        Console.ReadKey();
                                    }

                                    break;
                                case 2:
                                    string text = task.answer;
                                    Console.WriteLine("Enter: ");
                                    string search = Console.ReadLine();

                                    unevailLetter(search.First(), task.answer);
                                    Console.WriteLine("Word " + currentGuess);
                                   
                                 
                                      
                                    break;
                                case 3:
                                    using (System.IO.StreamWriter file = new StreamWriter(Score_path, true, Encoding.Default))
                                    {
                                        file.WriteLine(Nickname + " got " + Uscore + " points");
                                    }
                                    exit = true;
                                    break;
                                    
                            }
                            Console.Clear();
                           
                            
                        }
                        while (!exit);

                        break;
                    case 2:
                        string Scoreline;
                        using (StreamReader sp = new StreamReader(Score_path, System.Text.Encoding.Default))
                        {
                            while ((Scoreline = sp.ReadLine()) != null)
                            {
                                Console.WriteLine(Scoreline);
                            }
                        }
                        break;
                    case 3:
                        string GRline;
                        using (StreamReader gr = new StreamReader(Gamerules, System.Text.Encoding.Default))
                        {
                            while ((GRline = gr.ReadLine()) != null)
                            {
                                Console.WriteLine(GRline);
                            }
                        }

                        break;
                    case 4:
                        Console.WriteLine("Ви вирiшили вийти");
                        break;
                    default:
                        Console.WriteLine("Помилка невiрний ввiд...");
                        break;
                }
                Console.Write("\n\n\t\t\tНажмiть на будь-яку клавiшу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 4);



        }

        private void unevailLetter(char c, string answer)
        {
            var buffer = currentGuess.ToCharArray();
            for (var i=0; i<answer.Length; i++)
            {
                if (answer[i] == c)
                {
                    buffer[i] = c;
                }
            }
            currentGuess = new String(buffer);
        } 
    }
}