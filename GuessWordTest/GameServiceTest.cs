using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessWordGame;
using Moq;

namespace GuessWordTest
{
    [TestClass]
    public class GameServiceTest
    {

        [TestMethod]
        public void TestMethodSorryAndGuessLetterCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showSorry("Sorry, friend"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessLetter("letter");

            gameViewMock.Verify(x => x.showSorry("Sorry, friend"), Times.Once());
        }

        [TestMethod]
        public void TestMethodTaskAndGuessWordCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showTask(new Task()));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessWord("letter");

            gameViewMock.Verify(x => x.showTask(new Task()), Times.Once());
        }

        [TestMethod]
        public void TestMethodCurrentGuessAndStartCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showCurrentGuess("Wii"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCurrentGuess("Wii"), Times.Once());
        }

        [TestMethod]
        public void TestMethodCongratulationsAndStartCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showCongradulations("You lucky!"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCongradulations("You lucky!"), Times.Once());
        }

       

    }
}
