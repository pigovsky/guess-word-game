using Prism.Mvvm;
using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Input;
using Prism.Commands;
using MindFusion.UI.Wpf;
using System;
using System.Linq;
using System.Windows;

namespace Guess_word_game.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region Fields
        private readonly IQuestionsProvider _questionProvider;
        private string _title = "Guess word game";
        private bool _isKeyboardEabled;
        private bool _isTextBoxEnabled;

        private Question _currentQuestion;

        private int _score;

        private string _scoreText;
        private string _task;
        private string _answer;

        private ObservableCollection<Letter> _buttonsTextCollection;
        #endregion

        #region Properties        
        public ICommand ButtonClickCommand
        {
            get{ return new DelegateCommand<VirtualKeyEventArgs>(OnButtonClick); }
        }

        public ICommand GuessWordCommand
        {
            get{ return new DelegateCommand(OnGuessingWord); }
        }

        public bool IsKeyboardEnabled
        {
            get { return _isKeyboardEabled; }
            set { SetProperty(ref _isKeyboardEabled, value); }
        }

        public bool IsTextBoxEnabled
        {
            get { return _isTextBoxEnabled; }
            set { SetProperty(ref _isTextBoxEnabled, value); }
        }

        public string Answer
        {
            get { return _answer; }
            set { SetProperty(ref _answer, value); }
        }

        public ObservableCollection<Letter> ButtonsTextCollection      
        {
            get { return _buttonsTextCollection; }
            set { SetProperty(ref _buttonsTextCollection, value); }
        }

        public string Task
        {
            get { return _task; }
            set { SetProperty(ref _task, value); }
        }

        public string ScoreText
        {
            get { return _scoreText; }
            set { SetProperty(ref _scoreText, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion

        #region Constructor 
        public MainWindowViewModel(IQuestionsProvider questionProvider)
        {
            _questionProvider = questionProvider;
            _currentQuestion = _questionProvider.GetQuestion();

            ScoreText = "Srore: 0";
            IsKeyboardEnabled = true;
            IsTextBoxEnabled = true;

            InitCells();
        }
        #endregion

        #region GuessingWholeWordMethods    
        private void OnGuessingWord()
        {
            if (String.IsNullOrEmpty(Answer))
                return;

            if (String.Equals(Answer, _currentQuestion.Answer, StringComparison.CurrentCultureIgnoreCase))
            {
                _score += 100;
                UpdateScore();

                _currentQuestion = _questionProvider.GetQuestion();
                InitCells();
            }
            else
            {
                _score -= 100;
                UpdateScore();

                MessageBox.Show("You are wrong. -100 points, sorry.", "Hahaha");
            }

            Answer = String.Empty;
        }
        #endregion

        #region StartingNewTaskMethods
        private void InitCells()
        {
            Task = _currentQuestion.Task;

            if (_currentQuestion.Answer.Equals(String.Empty))
            {
                IsKeyboardEnabled = false;
                IsTextBoxEnabled = false;
            }

            var letters = new List<Letter>();

            for (int i = 0; i < _currentQuestion.Answer.Length; i++)
            {
                letters.Add(new Letter() { Value = String.Empty });
            }

            ButtonsTextCollection = new ObservableCollection<Letter>(letters);
        }
        #endregion

        #region CheckingLetterMethods        
        private void OnButtonClick(VirtualKeyEventArgs args)
        {
            if (args == null)            
               return;
            
            string keyText = string.Empty;

            try
            {
                keyText = args.Key.GetType().GetProperty("CapitalCase").GetValue(args.Key).ToString();
            }
            catch (Exception){}

            ValidateKeyText(keyText);
        }

        private void ValidateKeyText(string keyText)
        {
            if (!string.IsNullOrEmpty(keyText))
            {
                if (char.IsLetter(keyText[0]))
                {
                    if (IsPressed(keyText))
                    {
                        return;
                    }
                    else
                    {
                        if (IsKeyLetter(keyText))
                        {
                            var letterPositions = GetLetterPositions(keyText);

                            SetLetter(keyText, letterPositions);                        
                        }
                        else
                        {
                            _score--;
                            UpdateScore();
                        }
                    }
                }
            }
        }

        private void UpdateScore()
        {
            ScoreText = "Score: " + _score.ToString();
        }

        private bool IsPressed(string keyText)
        {
            return ButtonsTextCollection.Any(x => x.Value.Equals(keyText));
        }

        private bool IsKeyLetter(string keyText)
        {
            return _currentQuestion.Answer.Any(x => (x.ToString().Equals(keyText)));
        }

        private List<int> GetLetterPositions(string letter)
        {
            List<int> letterPositionsList = new List<int>();
            
            for (int i = 0; i < _currentQuestion.Answer.Length; i++)
            {
                var letterFromAnswer = _currentQuestion.Answer[i].ToString();

                if (letterFromAnswer.Equals(letter))
                {
                    letterPositionsList.Add(i);
                }
            }

            if (letterPositionsList.Count > 0)
            {
                _score += letterPositionsList.Count;
                UpdateScore();
            }

            return letterPositionsList;           
        }

        private void SetLetter(string letter, List<int> positions)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                ButtonsTextCollection[positions[i]].Value = letter;
            }

            CheckWord();
        }

        private void CheckWord()
        {
            var word = string.Empty;

            for (int i = 0; i < ButtonsTextCollection.Count; i++)
            {
                word += ButtonsTextCollection[i].Value;
            }

            if (word.Equals(_currentQuestion.Answer))
            {
                _score += 100;
                UpdateScore();

                _currentQuestion = _questionProvider.GetQuestion();
                InitCells();
            }
        }
    }
    #endregion
}