using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_word_game
{
    interface TaskProvider
    {
         Task Get();
    }
}
