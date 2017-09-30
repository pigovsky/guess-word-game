using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{

    class InfoClass
    {
        public string Nickname;
        public InfoClass()
        { }

        public InfoClass(string Nickname)
        {
            this.Nickname = Nickname;
        }

        public void Info()
        {
            Console.WriteLine("Welcome {0}\n", Nickname);

        }

    }
   
}
