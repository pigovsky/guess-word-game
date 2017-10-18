using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessWordGame
{
  
       public interface GameService
       {
           GameView gameView { get; set; }
           TaskProvider taskProvider { get; set; }
           void guessWord(String word);
           void guessLetter(String letter);
           void start();
       
    }
}
