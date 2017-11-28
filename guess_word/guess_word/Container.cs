using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_word
{
    class Container
    {
        public string Quest
        {
            get;
            private set;
        }
        public string Answer
        {
            get;
            private set;
        }

        public Container(string an,string quest)
        {
            Answer = an;
            Quest = quest;
        }
        public Container(string[]param)
        {
            Answer = param[1];
            Quest = param[0];
        }
    }
}
