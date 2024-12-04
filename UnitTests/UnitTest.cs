using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tehnotair;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodA()
        {
            Equals(FormLogin.a, 1);
        }
        [TestMethod]
        public void TestMethodB()
        {
            Equals(FormLogin.b, 2);
        }
        [TestMethod]
        public void TestMethodC()
        {
            Equals(FormLogin.c, 3);
        }
    }
}
