using Guess_word_game.Models;

namespace Guess_word_game.Abstractions
{
    public interface IQuestionsProvider
    {
        Task GetQuestion();
    }
}
