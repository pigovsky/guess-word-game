using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Script.Serialization;

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
        [TestMethod]
        public void TaskProviderImpl2Test()
        {
            TaskProviderImpl2 taskpr2 = new TaskProviderImpl2();
            Task t1 = new Task();
            Task t2 = new Task();
            try
            {
                t1 = taskpr2.get();
                t2 = taskpr2.get();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Assert.Fail(ex.Message);
            }
            var js = new JavaScriptSerializer();
            Assert.AreNotEqual(js.Serialize(t1), js.Serialize(t2));
        }
    }
}
