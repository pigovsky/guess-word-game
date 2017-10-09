using System;
using Guess_word_game.Abstractions;
using System.Windows;

namespace Guess_word_game.Services
{
    public class NotificationService : INotificationService
    {
        public NotificationService() { }

        public void PrintCongratulationPlus100()
        {
            MessageBox.Show("You guessed a word !\n +100 points", "Congratulations", MessageBoxButton.OK,
                MessageBoxImage.Information, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        public void PrintSorryMinus100()
        {
            MessageBox.Show("Wrong answer.\n -100 points", "Hahaha", MessageBoxButton.OK,
                MessageBoxImage.Information, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        public void PrintCongratulationsLetterGuessed(int lettersCount)
        {
            MessageBox.Show("+ " + lettersCount.ToString(), "Letter guessed.", MessageBoxButton.OK,
                MessageBoxImage.Information, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        public void PrintSorryWrongLetter()
        {
            MessageBox.Show("-1 sorry.", "Wrong letter.", MessageBoxButton.OK,
                MessageBoxImage.Information, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        public void PrintSorryInvalidKey()
        {
            MessageBox.Show("Invalid key pressed. Press only letters, please.", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        public void PrintSorryLetterIsAlreadyGuessed()
        {
            MessageBox.Show("Letter is already guessed", "Notification", MessageBoxButton.OK,
                MessageBoxImage.Information, MessageBoxResult.OK,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
