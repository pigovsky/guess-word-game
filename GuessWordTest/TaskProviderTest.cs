using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessWordGame;


namespace GuessWordTest
{
    [TestClass]
    public class TaskProviderTest
    {
       [TestMethod]
        public void TestGetReturnsStringValue()
        {
            var tp = new TaskProviderImpl();

            tp.QuestionFromFile();

            var task = tp.Get();

            Assert.IsNotNull(task);
        }

        [TestMethod]
        public void TestMethodCheckTwoTaskEqual()
        {
            var taskProviderImpl = new TaskProviderImpl();
            taskProviderImpl.QuestionFromFile();

            var firsttask = taskProviderImpl.Get();
            var secondtask = taskProviderImpl.Get();

            Assert.AreNotEqual(firsttask, secondtask);
        }
    }
}
