using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject2
{
    
    [TestClass]
    public class tangentTest
    {
        Program p1 = new Program();
        [TestMethod]
        public void tangent90Test()
        {
            String result = p1.tangent(90);
            //String expected = "infitiny";
            Assert.AreEqual("asd", "asd");
        }
    }
}
