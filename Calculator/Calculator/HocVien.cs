using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HocVien
    {
        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double DiemMon1 { get; set; }
        public double DiemMon2 { get; set; }
        public double DiemMon3 { get; set; }

        public double DiemTrungBinh()
        {
            return (DiemMon1 + DiemMon2 + DiemMon3) / 3;
        }

        public bool CoTheNhanHocBong()
        {
            return DiemTrungBinh() >= 8.0 && DiemMon1 >= 5.0 && DiemMon2 >= 5.0 && DiemMon3 >= 5.0;
        }
    }
}
