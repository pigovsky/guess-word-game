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
            Assert.IsNotNull(question.Task);
        }
    }
}
