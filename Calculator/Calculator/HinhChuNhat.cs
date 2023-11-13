using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HinhChuNhat
    {
        public Diem TopLeft { get; set; }
        public Diem BottomRight { get; set; }

        public HinhChuNhat(Diem topLeft, Diem bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public double TinhDienTich()
        {
            int width = BottomRight.X - TopLeft.X;
            int height = TopLeft.Y - BottomRight.Y;
            return width * height;
        }

        public bool IsGiaoNhau(HinhChuNhat other)
        {
            int x1 = TopLeft.X;
            int y1 = TopLeft.Y;
            int w1 = BottomRight.X - TopLeft.X;
            int x2 = other.TopLeft.X;
            int y2 = other.TopLeft.Y;
            int w2 = other.BottomRight.X - other.TopLeft.X;

            return (x1 + w1 >= x2) && (x2 + w2 >= x1) && (y1 + w1 >= y2) && (y2 + w2 >= y1);
        }

    }
}
