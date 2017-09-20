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

            var test = taskProviderImp.Get();

            Assert.IsNotNull(test);
        }
    }
}
