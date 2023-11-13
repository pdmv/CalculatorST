using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void Setup()
        {
            c = new Calculation(10, 5);
        }

        [TestMethod] // TC1: a =10, b = 5, kq = 15
        public void Test_Cong()
        {
            int expected, actual;
            expected = 15;

            actual = c.Execute("+");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // TC2: a =10, b = 5, kq = 5
        public void Test_Tru()
        {
            int expected, actual;
            expected = 5;

            actual = c.Execute("-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // TC3: a =10, b = 5, kq = 50
        public void Test_Nhan()
        {
            int expected, actual;
            expected = 50;

            actual = c.Execute("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // TC4: a =10, b = 5, kq = 2
        public void Test_Chia()
        {
            int expected, actual;
            expected = 2;

            actual = c.Execute("/");

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod] // TC5: a =10, b = 5, kq = 2 -- FAILED (goi sai ham)
        //public void Test_Chia_Failed()
        //{
        //    int expected, actual;
        //    expected = 2;

        //    actual = c.Execute("x"); // here 

        //    Assert.AreEqual(expected, actual);
        //}

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod] // TC6: a =10, b = 0, kq = Ngoai le chia cho 0
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\DataForTest.csv", "DataForTest#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
