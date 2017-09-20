using PrismLab_1.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismLab_1.Model;


namespace PrismLab_1.Managers
{
    public class AnswerCheckManager : IAnswerCheckManager
    {
        public Boolean CheckAnswer(String correctAnswer, String userAnswer)
        {
            correctAnswer = correctAnswer.ToLower();
            userAnswer = userAnswer.ToLower();
            if (correctAnswer == userAnswer)
                return true;
            else
                return false;
        }

        public String CodingWord(string word)
        {
            String codeWord = "";
            foreach (var letter in word)
                codeWord += "*";
            return codeWord;
        }


        public object[] CheckLetter(char letter, string answer, string codeWord)
        {
            int countOfRightLetter = 0;
            bool checkForFindLetterLater = false;
            string newCodeWord = "";
            letter = Char.ToLower(letter);

            foreach (var laterLetter in codeWord)
            {
                var laterLetterLower = Char.ToLower(laterLetter);
                if (laterLetterLower == letter)
                {
                    checkForFindLetterLater = true;
                    break;
                }
            }
            if (checkForFindLetterLater)
                return new object[] { codeWord, countOfRightLetter };

            foreach(var ansLetter in answer)
            {
                var ansLetterLow = Char.ToLower(ansLetter);
                if (ansLetterLow == letter)
                {
                    newCodeWord += ansLetter;
                    countOfRightLetter++;
                }
                else
                    newCodeWord += "*";
            }
            string finalCodeWord = "";
            for(int i =0; i < codeWord.Length; i++)
            {
                if (codeWord[i] == '*' && newCodeWord[i] != '*')
                    finalCodeWord += newCodeWord[i];
                else 
                    finalCodeWord += codeWord[i];

            }
            object[] arrayOfObj = { finalCodeWord, countOfRightLetter };
            return arrayOfObj;
        }
    }
}