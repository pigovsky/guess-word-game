using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_word_game
{
    public class TaskProviderImpl : TaskProvider
    {
        public int a = 0;
       
        Task[] tasks = {
            new Task() { question = "Capital of Ukraine", answer = "Kyiv" },
            new Task() { question = "Capital of France", answer = "Paris" }
        };

        public Task Get()
        {
            return tasks [a++];

        } 
    }
}
