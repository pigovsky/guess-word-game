using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    public class TaskProviderImplemet : TaskProvider
    {
        private int _counter;
        private List<Task> _listOfTasks;

        public TaskProviderImplemet()
        {
            _counter = 0;
            _listOfTasks = new List<Task>();
        }

        public Task Get()
        {
            if (_counter != (_listOfTasks.Count - 1))
            {
                var task = _listOfTasks[_counter];
                _counter++;
                return task;
            }
            else return new Task();
        }

        public void GetQuestionsFromFile()
        {
            try
            {
                var stringText = File.ReadAllText("questionJson.txt");
                _listOfTasks = JsonConvert.DeserializeObject<List<Task>>(stringText);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
