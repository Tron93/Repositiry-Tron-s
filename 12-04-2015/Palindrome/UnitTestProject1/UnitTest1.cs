using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Class1 newClass = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, newClass.Method("civic"));         
        }

        [TestMethod]
        public void TestMethod2()
        {
                    Assert.AreEqual(true, newClass.Method("ciciv"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(newClass.Method("anna"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(newClass.Method("alan"));
        }
           
        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(newClass.Method("cvit"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(newClass.Method("civil"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(newClass.Method("Anna"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(newClass.Method("Аргентина манит негра!?!"));
        }
    }
}
