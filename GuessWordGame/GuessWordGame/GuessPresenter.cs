using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    public class GuessPresenter
    {
        private readonly IMainForm _view;
        private readonly IGuessManager _manager;
        private readonly IMessageService _messageService;
        public GuessPresenter(IMainForm view, IGuessManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;
            _view.VerifyClick += _view_VerifyClick;
            _view.HalfWordClick += _view_HalfWordClick;
            _view.FirstLastLetterClick += _view_FirstLastLetterClick;
            _view.Auth += _view_Auth;
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
        private void _view_Auth(object sender, EventArgs e)
        {
            if (_manager.Auth(_view.auth.Text) != false)
            {
                _view.yourQ.Visible = true;
                _view.yourA.Visible = true;
                _view.yourAnswer.Visible = true;
                _view.LQuestion.Visible = true;
                _view.name.Visible = false;
                _view.auth.Visible = false;
                _view.welcome.Visible = false;
                _view.group1.Visible = true;
                _view.group2.Visible = true;
                _view.verify.Visible = true;
                _view.scoreLabel.Visible = true;
                _manager.FirstEntrance();
                _view.setScore(_manager.CurrentScore());
                _view.Question = _manager.getTask();
            }
            else
            {
                _messageService.showError("Неправильне ім'я користувача");
            }
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
                            if(quest == null)
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
                                if (quest == null)
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
    }
}
