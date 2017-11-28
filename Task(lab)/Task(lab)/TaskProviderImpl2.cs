using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Resources;

namespace Task_lab_
{
    public class TaskProviderImpl2 : TaskProvider
    {
        private int number_of_item = -1;
        List<Task> items;
        public Task get()
        {
            if (number_of_item == -1)
            {
                string path = "task.json";
                using (StreamReader r = new StreamReader(path))
                {
                    string json2 = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<Task>>(json2);
                }
            }
            number_of_item++;
            if (number_of_item > items.Count - 1)
                throw new ArgumentOutOfRangeException();
            else
                return items[number_of_item];
        }
    }
}
