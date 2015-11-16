using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMeData;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpData data = new HttpData();
            Assert.AreEqual(data.GetStringJsonData(), "");
        }
    }
}
