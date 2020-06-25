using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HoangKimTuyen_043
{
    class Library
    {
        // tính chu vi tam giác
        public double ChuviTamGiac(double a, double b, double c)
        {
            return a + b + c;
        }

        // tính diện tích tam giác
        public double DientichTamGiac(double a, double b, double c)
        {
            double p = (double)ChuviTamGiac(a, b, c)/2;
            return (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // kiểm tra có phải tam giác hay không?
        public bool KiemTraTamGiac(double a, double b, double c)
        {
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // tính chu vi hcn
        public double ChuViHCN(double chieudai, double chieurong)
        {
            return (chieudai + chieurong) * 2;
        }

        // tính diện tích hcn
        public double DienTichHCN(double chieudai, double chieurong)
        {
            return chieudai * chieurong;
        }

        // tính chu vi hình tròn
        public double ChuViHinhTron(double r)
        {
            return (double)r * 2 * Math.PI;
        }

        // tính diện tích hình tròn
        public double DienTichHinhTron(double r)
        {
            return (double)r * r * Math.PI;
        }
    }
}
