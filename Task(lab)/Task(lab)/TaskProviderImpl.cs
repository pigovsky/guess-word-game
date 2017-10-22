using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_lab_
{
    public class TaskProviderImpl : TaskProvider
    {
        public Task get()
        {
            return new Task("Hello","this is test");
        }
    }
}
