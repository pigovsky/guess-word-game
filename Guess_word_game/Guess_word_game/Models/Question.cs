using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game.Models
{
    public class Question: BindableBase
    {
        private string _task;

        private string _answer;

        public string Task
        {
            get { return _task; }
            set { SetProperty(ref _task, value); }
        }

        public string Answer
        {
            get { return _answer; }
            set { SetProperty(ref _answer, value); }
        }
    }
}