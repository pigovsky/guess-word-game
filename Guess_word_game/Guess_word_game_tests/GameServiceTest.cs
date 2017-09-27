using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using Guess_word_game.Services;
using Moq;

namespace Guess_word_game_tests
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void GetQuestionReturnsNotNUll()
        {
            var questionProviderMock = new Mock<IQuestionsProvider>();

            questionProviderMock.Setup(x => x.GetQuestion()).Returns(new Question());

            var gameServiceImpl = new GameService(questionProviderMock.Object);

            Assert.IsNotNull(gameServiceImpl.GetTask());
        }
    }
}
