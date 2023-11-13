using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class QuanLyHocVien
    {
        private List<HocVien> danhSachHocVien;  

        public QuanLyHocVien()
        {
            danhSachHocVien = new List<HocVien>();
        }

        public void ThemHocVien(HocVien hocVien)
        {
            danhSachHocVien.Add(hocVien);
        }

        public List<HocVien> LayDanhSachHocVienDatHocBong()
        {
            return danhSachHocVien.Where(hv => hv.CoTheNhanHocBong()).ToList();
        }

        public List<HocVien> DanhSachHocVien()
        {
            return this.danhSachHocVien;
        }
    }
}
