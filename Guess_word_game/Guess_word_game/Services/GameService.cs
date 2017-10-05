using System;
using Guess_word_game.Abstractions;
using System.Linq;
using System.Collections.Generic;

namespace Guess_word_game.Services
{
    public class GameService: IGameService
    {
        public int Score { get; set; }

        public GameService() { }

        public void StartGame()
        {
            Score = 0;
        }

        public bool IsLetterGuessed(string letter, string word)
        {
            return word.Contains(letter);
        }

        public bool IsKeyLetter(string letter, string word)
        {
            return word.Any(x => String.Equals(x.ToString(), letter, StringComparison.CurrentCultureIgnoreCase));
        }
    
        public List<int> GetLetterPositions(string letter, string word)
        {
            List<int> letterPositionsList = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                var letterFromAnswer = word[i].ToString();

                if (letterFromAnswer.Equals(letter))
                {
                    letterPositionsList.Add(i);
                }
            }

            return letterPositionsList;
        }
               
        public bool GuessWord(string word, string answer)
        {
            return String.Equals(word, answer, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
