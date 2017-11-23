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

        public void TestStartCalled()
        {
            var taskproviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            var task = new Task()
            { question = "Capital of France", answer ="Paris"
            };

            taskproviderMoq.Setup(x => x.Get()).Returns(task);

            var gameservice = new GameServiceImp(gameViewMock.Object, taskproviderMoq.Object);

            gameservice.start();

            gameViewMock.Verify(x => x.showTask(task));
            gameViewMock.Verify(x => x.showCurrentGuess("*****"));
        }
       
        [TestMethod]
        public void TestGuessLetterShowSorry()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            var task = new Task()
            {
                question = "Capital of France?",
                answer = "Paris"
            };

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);

            gameServiceImpl.guessLetter("O");

            gameViewMock.Verify(x => x.showSorry("So sorry"), Times.Once());
        }

        [TestMethod]
        public void TestGuessLetterShowCongrad()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            var task = new Task()
            {
                question = "Capital of France?",
                answer = "Paris"
            };

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);

            gameServiceImpl.guessLetter("P");

            gameViewMock.Verify(x => x.showCongradulations("wiii"), Times.Once());
        }
        

        [TestMethod]
        public void TestGuessWordShowSorry()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            var task = new Task()
            {
                question = "Capital of France?",
                answer = "Paris"
            };
      

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessWord("word");

            gameViewMock.Verify(x => x.showSorry("Sorry"), Times.Once());
        }

        [TestMethod]
        public void TestGuessWordShowCongrad()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            var task = new Task()
            {
                question = "Capital of France?",
                answer = "Paris"
            };


            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.guessWord("Paris");

            gameViewMock.Verify(x => x.showCongradulations("wiii"), Times.Once());
        }

      /*  [TestMethod]
        public void TestMethodCurrentGuess()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

            gameViewMock.Setup(x => x.showCurrentGuess("Wii"));

            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCurrentGuess("Wii"), Times.Once());
        }

        [TestMethod]
        public void TestMethodCongratulations()
        {
            var taskProviderMoq = new Mock<TaskProvider>();
            var gameViewMock = new Mock<GameView>();

          
            var gameServiceImpl = new GameServiceImp(gameViewMock.Object, taskProviderMoq.Object);
            gameServiceImpl.start();

            gameViewMock.Verify(x => x.showCongradulations("You lucky!"), Times.Once());
        }
        
       
        */
    }
}
