using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskProviderImplemet taskProviderImplemet = new TaskProviderImplemet();
            taskProviderImplemet.GetQuestionsFromRepo();

            Console.ReadKey();
        }
    }
}
