using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace GuessWordTest
{
    [TestClass]
    public class TaskTest
    {
        [TestMethod]
        public void TestGetReturnsStringValue()
        {
            var tp = new TaskProviderImpl();

            var task = tp.Get();

            Assert.IsNotNull(task);
        }
    }
}
