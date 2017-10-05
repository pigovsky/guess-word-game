using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_word_game.Abstractions;
using Guess_word_game.Models;
using Guess_word_game.Services;
using Moq;
using System;

namespace Guess_word_game_tests
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void KeyLetterReturnsRightValue()
        {
            //var gameServiceImpl = new Mock<IGameService>();
            //gameServiceImpl.Setup(x => x.IsKeyLetter("B", "Berlin")).Returns(true);

            //Assert.IsTrue(gameServiceImpl.Object.IsKeyLetter("B", "Berlin"));
            var gameService = new GameService();

            var isKeyLetter = gameService.IsKeyLetter("R", "Berlin");
            var isNotKeyLetter = gameService.IsKeyLetter("a", "Berlin");

            Assert.IsTrue(isKeyLetter);
            Assert.IsFalse(isNotKeyLetter);
        }
    }
}
