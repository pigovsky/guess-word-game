using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Task_lab_
{
    public class TaskProviderImpl3 : TaskProvider
    {
        private int number_of_item = -1;
        List<Task> items;
        public bool localy = false;
        public string url = "https://raw.githubusercontent.com/vitali-mykytiuk/guess-word-game/master/Task(lab)/Task(lab).Tests/bin/Debug/task.json";
        public Task get()
        {
            if (number_of_item == -1)
            {
                try
                {                
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = WebRequestMethods.Http.Get;
                    request.Accept = "application/json";
                    var response = (HttpWebResponse)request.GetResponse();
                    var r = new StreamReader(response.GetResponseStream());
                    items = JsonConvert.DeserializeObject<List<Task>>(r.ReadToEnd());
                }
                catch
                {
                    localy = true;
                    string path = "task.json";
                    using (StreamReader r = new StreamReader(path))
                    {
                        string json2 = r.ReadToEnd();
                        items = JsonConvert.DeserializeObject<List<Task>>(json2);
                    }
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
