using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using guess_word_game;
using System.Diagnostics;

namespace guess_word_game_test
{
    [TestClass]
    public class TaskProviderTest
    {
        [TestMethod]
        public void TestGetReturnsValidTask()
        {
            var taskProvider = new TaskProviderImpl();

            var task = taskProvider.Get();
            Assert.IsNotNull(task);
            Assert.IsNotNull(task.question);
            Assert.IsNotNull(task.answer);
        }

        [TestMethod]
        public void TestGetDiferent ()
        {
            var taskProvider = new TaskProviderImpl();

            var task1 = taskProvider.Get();
            var task2 = taskProvider.Get();
            Debug.WriteLine("are equal? {0} {1}", task1 == task2, task1.Equals(task2));
            Debug.WriteLine("{0} {1}", task1, task2);
            Assert.AreNotEqual(task1, task2);

        }
            
    }
}
