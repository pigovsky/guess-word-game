using Guess_word_game.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Guess_word_game.Services
{
    public class RestService
    {
        public List<Task> GetQuestions()
        {
            string jsonData = string.Empty;
            string url = "https://raw.githubusercontent.com/pigovsky/guess-word-game/master/tasks/all.json";

            HttpWebRequest httpRequest = null;
            HttpWebResponse response = null;

            try
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = WebRequestMethods.Http.Get;
                httpRequest.ContentType = "application/json; charset=utf-8";

                response = (HttpWebResponse)httpRequest.GetResponse();

            }
            catch (System.Exception ex)
            {

            }

            if (response != null)
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    jsonData = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Task>>(jsonData);
            }
           
            return new List<Task>();
        }
    }
}
