using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessWordGame
{
    public interface TaskProvider
    {
        Task Get();
    }
}
