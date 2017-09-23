using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    public class TaskProviderImplemet : TaskProvider
    {
        public Task Get()
        {
            return new Task();
        }
    }
}
