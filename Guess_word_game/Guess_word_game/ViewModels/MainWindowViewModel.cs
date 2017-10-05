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
using System.Text;
using System.Text.RegularExpressions;

namespace Guess_word_game.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region Fields
        private readonly IQuestionsProvider _questionProvider;
        private readonly IGameService _gameService;
        private string _title = "Guess word game";
        private bool _isKeyboardEabled;
        private bool _isTextBoxEnabled;

        private Question _currentQuestion;
        
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
        public MainWindowViewModel(IQuestionsProvider questionProvider, IGameService gameService)
        {
            _gameService = gameService;
            _questionProvider = questionProvider;
            _currentQuestion = _questionProvider.GetQuestion();

            ScoreText = "Srore: 0";
            IsKeyboardEnabled = true;
            IsTextBoxEnabled = true;

            _gameService.StartGame();
            InitCells();
        }
        #endregion

        #region GuessingWholeWordMethods    
        private void OnGuessingWord()
        {
            if (String.IsNullOrEmpty(Answer))
                return;

            if (_gameService.GuessWord(Answer, _currentQuestion.Answer))
            {
                _gameService.Score += 100;
                
                _currentQuestion = _questionProvider.GetQuestion();
                InitCells();

                MessageBox.Show("+100 points", "Nice");
            }
            else
            {
                _gameService.Score -= 100;

                MessageBox.Show("You are wrong. -100 points, sorry.", "Hahaha");
            }

            UpdateScore();
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
            
            string letter = string.Empty;

            try
            {
                letter = args.Key.GetType().GetProperty("CapitalCase").GetValue(args.Key).ToString();
            }
            catch (Exception) { }

            CheckLetter(letter);
        }

        private string GetPressedKeys()
        {
            string pressedKeys = String.Empty;

            foreach (var buttton in ButtonsTextCollection)
            {
                if (!pressedKeys.Contains(buttton.Value))
                {
                    pressedKeys += buttton.Value;
                }
            }

            return pressedKeys.ToString();
        }

        private void CheckLetter(string letter)
        {
            if (string.IsNullOrEmpty(letter) || !Regex.IsMatch(letter, @"^[a-zA-Z]+$"))
            {
                return;
            }
            else
            {
                var pressedKeys = GetPressedKeys();

                // if letter was already pressed
                if (_gameService.IsLetterGuessed(letter, pressedKeys)) 
                {
                    return;
                }
                else
                {
                    // is letter a part of asnwer
                    if (_gameService.IsKeyLetter(letter, _currentQuestion.Answer))
                    {
                        // get positions of letter in answer
                        var letterPositions = _gameService.GetLetterPositions(letter, _currentQuestion.Answer);

                        if (letterPositions.Count > 0)
                        {
                            _gameService.Score += letterPositions.Count;
                            UpdateScore();
                        }

                        SetLetter(letter, letterPositions);
                    }
                    else
                    {
                        _gameService.Score--;
                        UpdateScore();
                    }
                }
            }
        }

        private void UpdateScore()
        {
            ScoreText = "Score: " + _gameService.Score.ToString();
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
            var word = GetPressedKeys();            
            
            if (_gameService.GuessWord(word, _currentQuestion.Answer))
            {
                _gameService.Score += 100;
                UpdateScore();

                _currentQuestion = _questionProvider.GetQuestion();
                InitCells();
            }
        }
    }
    #endregion
}