using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_lab_.Tests
{
    [TestClass]
    public class TaskProviderTest
    {
        [TestMethod]
        public void getreturn_nullornot()
        {
            TaskProviderImpl fortest = new TaskProviderImpl();
            Task received = fortest.get();
            Assert.IsNotNull(received);
            Assert.IsNotNull(received.Answer);
            Assert.IsNotNull(received.Question);
        }
    }
}
