using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTesting
{

    [TestClass]
    public class TestRadix
    {
        public TestContext TestContext { get; set; }

        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void Setup()
        {
            // ...
        }

        // ---- Bai 4

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]    // TC: n = -1, expected: ArgumentException 
        public void TestRadix1()
        {
            Radix r = new Radix(-1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]    // TC: n = 255, radix = 1, expected: ArgumentException
        public void TestRadix2()
        {
            Radix r = new Radix(255);
            string s = r.ConvertDecimalToAnother(1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]    // TC: n = 255, radix = 17, expected: ArgumentException
        public void TestRadix3()
        {
            Radix r = new Radix(255);
            string s = r.ConvertDecimalToAnother(17);
        }

        [TestMethod]    // TC: n = 255, radix = 16, expected = "FF"
        public void TestRadix4()
        {
            Radix r = new Radix(255);
            string expected = "FF";

            string actual = r.ConvertDecimalToAnother(16);

            Assert.AreEqual(expected, actual);
        }
    }
}
