using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using queueTrigger;

namespace UnitTestProjectBlob2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         string name =   testQueueTrigger.Run("lalith");
            Assert.AreEqual("lalit", name);


        }
    }
}
