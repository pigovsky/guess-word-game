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

            var task = tp.Get();

            Assert.IsNotNull(task);
        }
    }
}
