using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWordGame
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			MainForm form = new MainForm();
            MessageService service = new MessageService();
			GuessManager manager = new GuessManager();
			
			GuessPresenter presenter = new GuessPresenter(form,manager,service);
            Application.Run(form);
        }
    }
}
