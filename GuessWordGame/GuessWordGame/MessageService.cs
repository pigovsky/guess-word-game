using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWordGame
{
    public interface IMessageService
    {
		void showCongratulations(string messsage);
		void showError(string error);
    }
    public class MessageService : IMessageService
    {
		public void showCongratulations(string messsage)
		{
			MessageBox.Show(messsage,"Вітаємо", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		public void showError(string error)
		{
			MessageBox.Show(error,"Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
    }
}
