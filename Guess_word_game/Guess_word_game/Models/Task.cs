using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game.Models
{
    public class Task : BindableBase
    {
        private string _question;

        private string _answer;

        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
        }

        public string Answer
        {
            get { return _answer; }
            set { SetProperty(ref _answer, value); }
        }
    }
}