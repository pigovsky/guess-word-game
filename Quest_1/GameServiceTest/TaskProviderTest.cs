using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quest_1;

namespace Quest_1_Test
{
    [TestClass]
    public class TaskProviderTest
    {
        [TestMethod]
        public void TestGetReturnsNotNull()
        {
            var taskProviderImp = new TaskProviderImplemet();
            taskProviderImp.GetQuestionsFromFile();

            var test = taskProviderImp.Get();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void TestGetTwoDifferentAnswerFromMethodGet()
        {
            var taskProviderImp = new TaskProviderImplemet();
            taskProviderImp.GetQuestionsFromFile();

            var firstTask = taskProviderImp.Get();
            var secondTask = taskProviderImp.Get();

            Assert.AreNotEqual(firstTask, secondTask);
        }
    }
}
