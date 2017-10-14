using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Guess_word_game.Providers
{
    public class QuestionFromFileProvider : IQuestionsProvider
    {
        private readonly List<Task> _questions;
        private int _questionId = 0;

        public QuestionFromFileProvider()
        {
            _questions = GetQuestions(); 
        }
        
        private List<Task> GetQuestions()
        {
            string textFromFile = string.Empty;

            try
            {             
                textFromFile = File.ReadAllText("tasks.json", Encoding.UTF8);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);                
            }

            return JsonConvert.DeserializeObject<List<Task>>(textFromFile);
        }

        public Task GetQuestion()
        {
            return _questionId == _questions.Count ? new Task() { Question = "You won! Congratulations my friend.", Answer = "" }
                    : _questions[_questionId++];
        }
    }
}
