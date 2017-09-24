using Guess_word_game.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_word_game.Models;

namespace Guess_word_game.Providers
{
    public sealed class QuestionProvider : IQuestionsProvider
    {
        private readonly List<Question> _tasks;
        private int _currentTaskId = 0;

        public QuestionProvider()
        {
            _tasks = new List<Question>()
            {
                new Question() {Task = "What is the capital of Netherlands?", Answer = "AMSTERDAM"},
                new Question() {Task = "What is the capital of Ukraine?", Answer = "KYIV"},
                new Question() {Task = "What is the capital of Spain?", Answer = "MADRID"}

            };
        }

        public Question GetQuestion()
        {
            return _currentTaskId == _tasks.Count ? new Question() { Task = "You won! Congratulations my friend.", Answer = ""} 
                    : _tasks[_currentTaskId++];
        }
    }
}
