using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_lab_
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskProviderImpl2 task = new TaskProviderImpl2();
            Console.WriteLine(task.get().Question);
            Console.WriteLine(task.get().Question);
            Console.WriteLine(task.get().Question);
            Console.ReadLine();

        }
    }
}
