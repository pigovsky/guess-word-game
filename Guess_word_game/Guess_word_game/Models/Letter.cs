using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game.Models
{
    // entity for binding buttons and creating observableCollection
    public class Letter : BindableBase
    {
        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
    }
}
