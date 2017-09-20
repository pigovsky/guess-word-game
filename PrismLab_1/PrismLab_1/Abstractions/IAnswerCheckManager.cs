using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismLab_1.Model;

namespace PrismLab_1.Abstractions
{
    public interface IAnswerCheckManager
    {
        Boolean CheckAnswer(String correctAnswer, String userAnswer);
        String CodingWord(String word);
        Object[] CheckLetter(Char letter, String answer, String codeWord);
    }
}
