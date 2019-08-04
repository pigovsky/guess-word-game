using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForRequest
{
    interface IGameView
    {
        void ShowGameOver();
        void ShowQuestion(Task task);
        void ShowAnswer(string TempStar);
        void ShowNotification(string message, Color color);
        void ShowScore(int Score);       
    }
}
