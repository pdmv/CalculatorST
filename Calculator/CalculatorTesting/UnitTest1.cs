using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using System.Collections.Generic;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        public TestContext TestContext { get; set; }

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

        [TestMethod] // TC5: a =10, b = 5, kq = 2 -- FAILED (goi sai ham)
        public void Test_Chia_Failed()
        {
            int expected, actual;
            expected = 2;

            actual = c.Execute("x"); // here 

            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod] // TC6: a =10, b = 0, kq = Ngoai le chia cho 0
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"./Data/TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        
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


        // ----------------------------------------------------------
        // Bai tap lam them


        // ---- Bai 2

        [TestMethod]    // TC: x = 2; n = 0; expected = 1
        public void TestPower1()
        {
            double x = 2.0;
            int n = 0;
            double expected = 1.0;

            double actual = Calculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    // TC: x = 2; n = 2; expected = 4
        public void TestPower2()
        {
            double x = 2.0;
            int n = 2;
            double expected = 4.0;

            double actual = Calculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    // TC: x = 2; n = -1; expected = 0.5
        public void TestPower3()
        {
            double x = 2.0;
            int n = -1;
            double expected = 0.5;

            double actual = Calculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }


        // ---- Bai 3

        [TestMethod]    // TC: n = 2, hệ số {1, 2, 3}, x = 2, expected = 17
        public void TestPolynomial1()
        {
            int n, x, expected;
            List<int> a = new List<int>();

            n = 2;
            x = 2;
            expected = 17;
            a.AddRange(new[] { 1, 2, 3 });

            Polynomial p = new Polynomial(n, a);
            int actual = p.Cal(x);

            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentException), "Invalid Data")]
        [TestMethod]
        // TC: n = 2, hệ số {1, 2}
        // expected: ArgumentException("Invalid Data")
        public void TestPolynomial2()
        {
            int n = 2;
            List<int> a = new List<int>();

            a.AddRange(new[] { 1, 2 });

            Polynomial p = new Polynomial(n, a);
        }

        [ExpectedException(typeof(ArgumentException), "Invalid Data")]
        [TestMethod]
        // TC: n = 2, hệ số {1, 2, 3, 4}
        // expected: ArgumentException("Invalid Data")
        public void TestPolynomial3()
        {
            int n = 2;
            List<int> a = new List<int>();

            a.AddRange(new[] { 1, 2, 3, 4 });

            Polynomial p = new Polynomial(n, a);
        }

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"./Data/TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        //[TestMethod]
        //public void TestWithDataSource2()
        //{
        //    int a = int.Parse(TestContext.DataRow[0].ToString());
        //    int b = int.Parse(TestContext.DataRow[1].ToString());
        //    string operation = TestContext.DataRow[2].ToString().Remove(0,1);
        //    int expected = int.Parse(TestContext.DataRow[3].ToString());

        //    Calculation c = new Calculation(a, b);
        //    int actual = c.Execute(operation);
        //    Assert.AreEqual(expected, actual);
        //}

        //    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"./Data/TestData3.csv", "TestData3#csv", DataAccessMethod.Sequential)]
        //    [TestMethod]
        //    public void TestWithDataSource3()
        //    {
        //        double x = Convert.ToDouble(TestContext.DataRow[0].ToString());
        //        int n = int.Parse(TestContext.DataRow[1].ToString());
        //        double expected = Convert.ToDouble(TestContext.DataRow[2].ToString());

        //        double actual = Calculation.Power(x, n);
        //        Assert.AreEqual(expected, actual);
        //    }
    }
}
