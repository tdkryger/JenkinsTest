using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest.UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Class1Add()
        {
            JenkinsTest.CL.Class1 c1 = new CL.Class1();

            Assert.AreEqual(9, c1.Add(4, 5));
        }
    }
}
