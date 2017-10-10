using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quest_1;
using Moq;

namespace GameServiceTest
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void ShowSorryAndGuessLetterCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showSorry("DDD"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessLetter("letter");

            gameViewMock.Verify(x => x.showSorry("DDD"), Times.Once());
        }

        [TestMethod]
        public void ShowTaskAndGuessWordCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showTask(new Task()));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessWord("letter");

            gameViewMock.Verify(x => x.showTask(new Task()), Times.Once());
        }

        [TestMethod]
        public void ShowCurrentGuessAndStartCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showCurrentGuess("RRR"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCurrentGuess("RRR"), Times.Once());
        }

        [TestMethod]
        public void ShowCongratulationsAndStartCalled()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showCongratulations("EEE"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCongratulations("EEE"), Times.Once());
        }
    }
}
