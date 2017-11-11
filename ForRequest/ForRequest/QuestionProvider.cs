using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace ForRequest
{
    class QuestionProvider
    {
        private List<Task> tasks;
        Random rnd = new Random();

        public QuestionProvider()
        {
            string url = "https://raw.githubusercontent.com/pigovsky/guess-word-game/master/tasks/all.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            var json = new StreamReader(resStream).ReadToEnd();
            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
        }

        public Task Question()
        {
            if (tasks.Count == 0)
            {
                return null;
            }
            int number = rnd.Next(tasks.Count);
            var task = tasks[number];
            tasks.Remove(task);
            return task;
        }
    }
}
