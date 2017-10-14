using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using Guess_word_game.Services;
using System.Collections.Generic;

namespace Guess_word_game.Providers
{
    public class QuestionFromWebResourseProvider : IQuestionsProvider
    {
        private List<Task> _list;
        private readonly RestService _restService;
        private int _questionId = 0;

        public QuestionFromWebResourseProvider()
        {
            _restService = new RestService();
            _list = _restService.GetQuestions();
        }

        public bool IsEmpty { get => _list.Count == 0 ? true : false; set { } }

        public Task GetQuestion()
        {
            if (_questionId == 1) // avoidance of Андорра-ла-Велья"
            {
                _questionId++;
            }
            else if(_questionId == _list.Count)
            {
                return new Task() { Question = "You won! Congratulations my friend.", Answer = "" };
            }

            return _list[_questionId++];
        }        
    }
}
