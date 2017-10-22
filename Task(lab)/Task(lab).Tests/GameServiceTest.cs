using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Task_lab_.Tests
{
    [TestClass]
    public class GameServiceTest
    {
        Mock<GameView> _gameView;
        Mock<TaskProvider> _taskProvider;
        GameServiceImpl gameServiceTest;
        [TestMethod]
        public void Start_Was_Called()
        {
            _gameView = new Mock<GameView>();
            _taskProvider = new Mock<TaskProvider>();
            gameServiceTest = new GameServiceImpl(_gameView.Object, _taskProvider.Object);
            _gameView.Setup(x => x.showTask(It.IsAny<Task>()));
            gameServiceTest.start();
            _gameView.VerifyAll();

        }
        [TestMethod]
        public void guessWord_and_showSorry_Was_Called()
        {
            _gameView = new Mock<GameView>();
            _taskProvider = new Mock<TaskProvider>();
            gameServiceTest = new GameServiceImpl(_gameView.Object, _taskProvider.Object);
            _gameView.Setup(x => x.showSorry(It.IsAny<String>()));
            _taskProvider.Setup(x => x.get()).Returns(new Task()
            {
                Answer = "Kiev",
                Question = "What is the capital of Ukraine?"
            });
            gameServiceTest.guessWord("YOYOYOYOYO");
            _gameView.VerifyAll();
        }
        [TestMethod]
        public void guessWord_and_showCongratulations_Was_Called()
        {
            _gameView = new Mock<GameView>();
            _taskProvider = new Mock<TaskProvider>();
            gameServiceTest = new GameServiceImpl(_gameView.Object, _taskProvider.Object);
            _gameView.Setup(x => x.showCongratulations(It.IsAny<String>()));
            _taskProvider.Setup(x => x.get()).Returns(new Task()
            {
                Answer = "Kiev",
                Question = "What is the capital of Ukraine?"
            });
            gameServiceTest.guessWord("Kiev");
            _gameView.VerifyAll();
        }
        [TestMethod]
        public void guessLetter_and_showSorry_Was_Called()
        {
            _gameView = new Mock<GameView>();
            _taskProvider = new Mock<TaskProvider>();
            gameServiceTest = new GameServiceImpl(_gameView.Object, _taskProvider.Object);
            _gameView.Setup(x => x.showSorry(It.IsAny<String>()));
            _taskProvider.Setup(x => x.get()).Returns(new Task()
            {
                Answer = "Kiev",
                Question = "What is the capital of Ukraine?"
            });
            gameServiceTest.guessLetter("h");
            _gameView.VerifyAll();
        }
        [TestMethod]
        public void guessLetter_and_showCongratulations_Was_Called()
        {
            _gameView = new Mock<GameView>();
            _taskProvider = new Mock<TaskProvider>();
            gameServiceTest = new GameServiceImpl(_gameView.Object, _taskProvider.Object);
            _gameView.Setup(x => x.showCongratulations(It.IsAny<String>()));
            _taskProvider.Setup(x => x.get()).Returns(new Task()
            {
                Answer = "Kiev",
                Question = "What is the capital of Ukraine?"
            });
            gameServiceTest.guessLetter("K");
            _gameView.VerifyAll();
        }
    }
}
