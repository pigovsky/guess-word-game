using Guess_word_game.Models;
using System.Collections.Generic;

namespace Guess_word_game.Abstractions
{
    public interface IGameService
    {        
        void StartGame();
        bool IsLetterGuessed(string letter, string word);
        bool IsKeyLetter(string letter, string word);
        bool GuessWord(string word, string answer);
        List<int> GetLetterPositions(string letter, string word);
        int Score { get; set; }
    }
}
