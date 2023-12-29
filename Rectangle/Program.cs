using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            Console.Write("Nhap chieu dai hinh chu nhat: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat: ");
            double width = double.Parse(Console.ReadLine());
            Rectangle b = new Rectangle(length, width);
            Console.WriteLine("Thong tin hinh chu nhat: ");
            Console.WriteLine("Hinh chu nhat so 1:\nChieu dai: {0}\nChieu rong: {1}\nChu vi: {2}\nDien tich: {3}",
                a.getLength(), a.getWidth(), a.findArea(), a.findPerimeter());
            Console.WriteLine("Hinh chu nhat so 2:\nChieu dai: {0}\nChieu rong: {1}\nChu vi: {2}\nDien tich: {3}",
    b.getLength(), b.getWidth(), b.findArea(), b.findPerimeter());
            Console.ReadLine();

        }
    }
}
