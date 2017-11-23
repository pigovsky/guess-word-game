using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GuessWordGame
{
    public class TaskProviderImpl : TaskProvider
    {
        private int counter;
        private List<Task> ListOfQuestion;

        public TaskProviderImpl()
        {
            counter = 0;
            ListOfQuestion = new List<Task>();
        }
        public Task Get()
        {
            if (counter != (ListOfQuestion.Count -1))
            {
                var task = ListOfQuestion[counter];
                counter++;
                return task;
            }

            return new Task();
        }

        public void QuestionFromFile()
        {
            
                var Text = File.ReadAllText("question.txt");
                ListOfQuestion = Json.JsonParser.Deserialize<List<Task>>(Text);

                   }
    }
}
