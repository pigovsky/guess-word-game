using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Security.Cryptography;
using System.Windows.Forms;


namespace GuessWordGame
{
    public class GuessPresenter
    {
        private readonly IMainForm _view;
        private readonly ILoginForm _viewLogin;
        private readonly IRegistrationForm _viewRegistration;
        private readonly IGuessManager _manager;
        private readonly IMessageService _messageService;
        private readonly IInformationForm _Information;
        //User myAccount;
        public GuessPresenter(IInformationForm Information,IRegistrationForm viewRegistration,ILoginForm viewLogin, IMainForm view, IGuessManager manager,
            IMessageService messageService)
        {
            _viewLogin = viewLogin;
            _view = view;
            _manager = manager;
            _messageService = messageService;
            _view.VerifyClick += _view_VerifyClick;
            _view.HalfWordClick += _view_HalfWordClick;
            _view.FirstLastLetterClick += _view_FirstLastLetterClick;
            _viewLogin.LogIn += _viewLogin_LogIn;
            _viewRegistration = viewRegistration;
            _viewRegistration.SignUp += _viewLogin_SignUp;
            _viewLogin.SignUp += SignUp;
            _Information = Information;
            _view.InformationClick += _view_InformationClick;
            _Information.SaveClick += _Information_SaveClick;
            
        }

        private void _Information_SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (_manager.Save(_Information.id, _Information.Surname, _Information.MyName,
                _Information.Login, _Information.Password,_Information.DateOfBirth,
                _Information.sex, _Information.EMail) == true)
                {
                    _messageService.showCongratulations("Зміни збережено");
                    _Information.Hidee();
                    _view.SetWelcome(_manager.getName());
                }
                else
                {
                    _messageService.showError("Помилка. Введіть ваш дійсний пароль");
                }
            }
            catch (Exception ex)
            {
                _messageService.showError(ex.Message);
            }
        }

        private void _view_InformationClick(object sender, EventArgs e)
        {
            _Information.Showw(_manager.GetUser());
        }

        private void SignUp(object sender, EventArgs e)
        {
            _viewLogin.Hidee();
            _viewRegistration.Showw();
        }

        private void _view_FirstLastLetterClick(object sender, EventArgs e)
        {
            try
            {
                if (_manager.CurrentScore() >= 30)
                {
                    _view.FirstLastLetter = _manager.LastAndFirst();
                    _view.setScore(_manager.CurrentScore());
                }
                else
                    _messageService.showError("У вас недостатньо на рахунку для використання цієї підказки");
            }
            catch (Exception ex)
            {
                _messageService.showError(ex.Message);
            }
        }

        private void _view_HalfWordClick(object sender, EventArgs e)
        {
            try
            {
                if (_manager.CurrentScore() >= 50)
                {
                    _view.HalfWord = _manager.HalfOfWord();
                    _view.setScore(_manager.CurrentScore());
                }
                else
                    _messageService.showError("У вас недостатньо на рахунку для використання цієї підказки");
            }
            catch (Exception ex)
            {
                _messageService.showError(ex.Message);
            }
        }
        private void _viewLogin_LogIn(object sender, EventArgs e)
        {
            if (_viewLogin.Login != string.Empty && _viewLogin.Password != string.Empty)
            {
                bool auth;
                auth = _manager.Auth(_viewLogin.Login, _viewLogin.Password);
                if (auth == true)
                {
                    _viewLogin.Hidee();
                    _view.Vision();
                    _view.setScore(_manager.CurrentScore());
                    _view.Question = _manager.getTask();
                    _view.SetWelcome(_manager.getName());
                }
                else
                {
                    _messageService.showError("Неправильно введений логін або пароль");
                }
            }
            else
                _messageService.showError("Будь ласка, заповніть поля логіну та пароля");
        }

        private void _view_VerifyClick(object sender, EventArgs e)
        {
            try
            {
                if (_view.InputWord != string.Empty)
                {
                    if (_view.typeVerify == 1)
                    {
                        if (_manager.GuessWord(_view.InputWord))
                        {
                            _messageService.showCongratulations("Ви відгадали слово");
                            _manager.RaiseScorebyWord();
                            _view.setScore(_manager.CurrentScore());
                            string quest = _manager.getTask();
                            _view.Question = quest;
                            _view.Letters = string.Empty;
                            _view.InputWord = string.Empty;
                            if (quest == "WIN")
                            {
                                _messageService.showCongratulations("Вітаємо ви пройшли гру");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            _manager.ReduceScorebyWord();
                            _view.setScore(_manager.CurrentScore());
                            _messageService.showError("Неправильна відповідь");
                        }
                    }
                    else if (_view.typeVerify == 2)
                    {
                        if (_manager.GuessLetter(_view.InputWord.ToCharArray()[0]))
                        {
                            string temp = _manager.GetWordbyLetter(_view.InputWord.ToCharArray()[0]);
                            _view.Letters = temp;
                            if (temp.IndexOf("*") == -1)
                            {
                                _messageService.showCongratulations("Ви відгадали слово");
                                _manager.RaiseScorebyWord();
                                _view.setScore(_manager.CurrentScore());
                                string quest = _manager.getTask();
                                _view.Question = quest;
                                _view.Letters = string.Empty;
                                _view.InputWord = string.Empty;
                                if (quest == "WIN")
                                {
                                    _messageService.showCongratulations("Вітаємо ви пройшли гру");
                                    Environment.Exit(0);
                                }
                            }

                        }
                        else
                        {
                            _manager.ReduceScorebyLetter();
                            _view.setScore(_manager.CurrentScore());
                            _messageService.showError("Неправильна відповідь");
                        }
                    }
                }
                else
                    _messageService.showError("Заповніть поле відповіді");
            }
            catch (Exception ex)
            {
                _messageService.showError(ex.Message);
            }
        }
        private void _viewLogin_SignUp(object sender, EventArgs e)
        {
            try
            {
                if (_manager.SignUp(_viewRegistration.Surname, _viewRegistration.MyName,
                _viewRegistration.Login, _viewRegistration.Password, _viewRegistration.DateOfBirth,
                _viewRegistration.sex, _viewRegistration.EMail) == true)
                {
                    _messageService.showCongratulations("Ви успішно зареєстровані");
                    _viewRegistration.Hidee();
                    _viewLogin.Showw();
                }
                else
                {
                    _messageService.showError("Помилка реєстрації. Логін зайнято");
                }
            }
            catch(Exception ex)
            {
                _messageService.showError(ex.Message);
            }
        }
    }
}
