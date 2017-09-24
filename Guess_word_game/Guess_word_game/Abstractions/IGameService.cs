using Guess_word_game.Models;

namespace Guess_word_game.Abstractions
{
    public interface IGameService
    {        
        Question GetTask();
        void StartGame();
    }
}
