﻿
using ServiceReference1;

namespace BinaryCalcTest
{
    [TestClass]
    public sealed class Test1
    {
        Service1Client client  = new Service1Client();
        [TestMethod]
        public void TestSimpleAddition()
        {
            Assert.AreEqual ("0", client.BinaryAdd("0", "0"));
            Assert.AreEqual("1", client.BinaryAdd("1", "0"));
            Assert.AreEqual("10", client.BinaryAdd("1", "1"));
            
        }

        [TestMethod]
        public void TestDifferentLengthsAddition()
        {
            Assert.AreEqual("111", client.BinaryAdd("101", "10"));
            Assert.AreEqual("10000", client.BinaryAdd("1111", "1"));

        }

        [TestMethod]
        public void TestLargeNumbersAddition()
        {
            Assert.AreEqual("11000011000010111", client.BinaryAdd("1010101010101010", "1101101101101101"));

            
        }

        [TestMethod]
        public void TestEdgeCasesAddition()
        {
            Assert.AreEqual("0", client.BinaryAdd("", ""));
            Assert.AreEqual("0", client.BinaryAdd("0", ""));
            Assert.AreEqual("1", client.BinaryAdd("", "1"));
        }
    }
}
