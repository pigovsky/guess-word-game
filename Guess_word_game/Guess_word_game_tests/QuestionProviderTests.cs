using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_word_game.Providers;

namespace Guess_word_game_tests
{
    [TestClass]
    public class QuestionProviderTests
    {
        [TestMethod]
        public void GetQuestionNotNull_Test()
        {
            var questionProvider = new QuestionProvider();

            var question = questionProvider.GetQuestion();

            Assert.IsNotNull(question);
            Assert.IsNotNull(question.Answer);
            Assert.IsNotNull(question.Question);
        }

        [TestMethod]
        public void GetReturnsDifferentQuestion_Test()
        {
            var questionFromFileProvider = new QuestionFromFileProvider();

            var question1 = questionFromFileProvider.GetQuestion();

            var question2 = questionFromFileProvider.GetQuestion();

            Assert.AreNotEqual(question1.Question, question2.Question);
        }
    }
}
