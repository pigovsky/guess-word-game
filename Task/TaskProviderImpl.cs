using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task
{
    public class TaskProviderImpl : TaskProvider
    {
        public Task Get()
        {
            return new Task("","");
        }
    }
}
