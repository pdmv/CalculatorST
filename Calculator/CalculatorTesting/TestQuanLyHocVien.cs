using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTesting
{
    [TestClass]
    public class TestQuanLyHocVien
    {
        private QuanLyHocVien quanLyHocVien;

        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void Setup()
        {
            quanLyHocVien = new QuanLyHocVien();
        }

        [TestMethod]
        public void ThemMoiHocVien()
        {
            HocVien hocVien = new HocVien { 
                MaSo = 1, 
                HoTen = "Nguyen Van A", 
                QueQuan = "Ha Noi", 
                DiemMon1 = 9.0, 
                DiemMon2 = 8.5, 
                DiemMon3 = 8.0 
            };

            quanLyHocVien.ThemHocVien(hocVien);

            CollectionAssert.Contains(quanLyHocVien.DanhSachHocVien(), hocVien);
        }

        [TestMethod]
        public void ThemHocVienCoDiemDuoi5_KoNhanHocBong()
        {
            HocVien hocVien = new HocVien { 
                MaSo = 1, 
                HoTen = "Nguyen Van B", 
                QueQuan = "Da Nang", 
                DiemMon1 = 10.0, 
                DiemMon2 = 10.0, 
                DiemMon3 = 4.5 
            };

            quanLyHocVien.ThemHocVien(hocVien);

            CollectionAssert.DoesNotContain(quanLyHocVien.LayDanhSachHocVienDatHocBong(), hocVien);
        }

        [TestMethod]
        public void ThemHocVienCoDiemTren5TrungBinhDuoi8_KoNhanHocBong()
        {
            HocVien hocVien = new HocVien { 
                MaSo = 1, 
                HoTen = "Nguyen Van C", 
                QueQuan = "Vinh", 
                DiemMon1 = 7.0, 
                DiemMon2 = 7.5, 
                DiemMon3 = 7.0 };

            quanLyHocVien.ThemHocVien(hocVien);

            CollectionAssert.DoesNotContain(quanLyHocVien.LayDanhSachHocVienDatHocBong(), hocVien);
        }

        [TestMethod]
        public void ThemHocVienCoDiemTrungBinhTren8_NhanHocBong()
        {
            HocVien hocVien = new HocVien
            {
                MaSo = 1,
                HoTen = "Nguyen Van D",
                QueQuan = "Ha Noi",
                DiemMon1 = 9.0,
                DiemMon2 = 8.5,
                DiemMon3 = 8.0
            };

            quanLyHocVien.ThemHocVien(hocVien);

            CollectionAssert.Contains(quanLyHocVien.LayDanhSachHocVienDatHocBong(), hocVien);
        }
    }
}
