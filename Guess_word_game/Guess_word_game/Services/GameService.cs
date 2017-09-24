using System;
using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using Guess_word_game.Providers;

namespace Guess_word_game.Services
{
    public class GameService: IGameService
    {
        private readonly IQuestionsProvider _questionProvider;

        public GameService(IQuestionsProvider questionProvider)
        {
            _questionProvider = questionProvider;
        }

        public Question GetTask()
        {
            return _questionProvider.GetQuestion();
        }

        public void StartGame()
        {            
        }
    }
}
