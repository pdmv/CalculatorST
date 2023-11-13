using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTesting
{
    
    [TestClass]
    public class TestHinhChuNhat
    {
        [TestMethod]    // TC: TopLeft(0, 5), BottomRight(4,0), expected = 20
        public void TestTinhDienTich()
        {
            Diem topLeft = new Diem(0, 5);
            Diem bottomRight = new Diem(4, 0);
            HinhChuNhat hinhChuNhat = new HinhChuNhat(topLeft, bottomRight);

            double dienTich = hinhChuNhat.TinhDienTich();

            Assert.AreEqual(20, dienTich);
        }

        [TestMethod]    // TC: HinhChuNhat1((0, 0), (5, 5)), HinhChuNhat2((3, 3), (8, 8)), expected = True
        public void TestIsGiaoNhau_True()
        {
            HinhChuNhat hinh1 = new HinhChuNhat(new Diem(0, 0), new Diem(5, 5));
            HinhChuNhat hinh2 = new HinhChuNhat(new Diem(3, 3), new Diem(8, 8));

            bool giaoNhau = hinh1.IsGiaoNhau(hinh2);

            Assert.IsTrue(giaoNhau);
        }

        [TestMethod]    // TC: HinhChuNhat1((0, 0), (5, 5)), HinhChuNhat2((6, 6), (10, 10)), expected = False
        public void TestIsGiaoNhau_False()
        {
            HinhChuNhat hinh1 = new HinhChuNhat(new Diem(0, 0), new Diem(5, 5));
            HinhChuNhat hinh2 = new HinhChuNhat(new Diem(6, 6), new Diem(10, 10));

            bool giaoNhau = hinh1.IsGiaoNhau(hinh2);

            Assert.IsFalse(giaoNhau);
        }
    }
}
