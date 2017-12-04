using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            LoginForm login = new LoginForm();
            RegistrationForm signUp = new RegistrationForm();
            InformationForm info = new InformationForm();
            GuessPresenter presenter = new GuessPresenter(info,signUp,login, form, manager, service);
            Application.Run(login);
        }
    }
}
