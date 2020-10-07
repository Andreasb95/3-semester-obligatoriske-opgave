using System;
using FanLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethodStringToShort()
        {
            FanOutput fan = new FanOutput("Ti", 15, 38);

        }

        [TestMethod]
        public void TestMethodGraderOutOfRange()
        {
            FanOutput fan = new FanOutput("Ti", 15, 80);

        }

        [TestMethod]
        public void TestMethodFugtOutOfRange()
        {
            
            FanOutput fan = new FanOutput("Ti", 15.5, 80);

        }

        [TestMethod]
        public void TestMethodIdToIncrease()
        {
            int expectedid = 3;
            FanOutput fan = new FanOutput("Ti", 15, 38);
            Assert.AreEqual(fan.Id, expectedid);
        }


        [TestMethod]
        public void TestToStringMethod()
        {
            FanOutput fanOutPutTestToString = new FanOutput("LoL", 20, 40);
            Console.WriteLine(fanOutPutTestToString);

        }
    }
}
