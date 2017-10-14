using Guess_word_game.Abstractions;
using System.Collections.Generic;
using Guess_word_game.Models;

namespace Guess_word_game.Providers
{
    public sealed class QuestionProvider : IQuestionsProvider
    {
        private readonly List<Models.Task> _tasks;
        private int _currentTaskId = 0;

        public QuestionProvider()
        {
            _tasks = new List<Models.Task>()
            {
                new Models.Task() {Question = "What is the capital of Netherlands?", Answer = "AMSTERDAM"},
                new Models.Task() {Question = "What is the capital of Ukraine?", Answer = "KYIV"},
                new Models.Task() {Question = "What is the capital of Spain?", Answer = "MADRID"}

            };
        }

        public bool IsEmpty { get { return _tasks.Count == 0 ? true : false; } set { } }

        public Task GetQuestion()
        {
            return _currentTaskId == _tasks.Count ? new Models.Task() { Question = "You won! Congratulations my friend.", Answer = ""} 
                    : _tasks[_currentTaskId++];
        }
    }
}
