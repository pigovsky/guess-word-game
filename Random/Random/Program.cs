using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomApliccatiom
{
    class Game
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("\t Вгадайте число!");

            Console.Write("Введiть початок iнтервалу: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiнець iнтервалу: ");
            int b = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int chislo = rnd.Next(a, b);
            int prov;

            do
            {
                Console.Write("Введiть число в iнтервалi вiд {0} до {1}: ", a, b);
                prov = int.Parse(Console.ReadLine());
                count++;
                if (prov == chislo)
                {
                    Console.WriteLine("Вiтаємо! Ви вгадали число!");    
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Вибачте! Число невiрне. Попробуйте ще раз.");         
                }
                Console.WriteLine("Кiлькiсть спроб: {0}", count);
            } while (prov != chislo);
            
        }
    }
}
