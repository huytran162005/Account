using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tu cua phan so thu nhat: ");
            int tu1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau cua phan so thu nhat: ");
            int mau1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap tu cua phan so thu hai: ");
            int tu2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau cua phan so thu hai: ");
            int mau2 = int.Parse(Console.ReadLine());

            PhanSo a = new PhanSo(tu1, mau1);
            PhanSo b = new PhanSo(tu2, mau2);

            a.toiGian(a);
            b.toiGian(b);

            PhanSo kqcong = a.cong(b);
            PhanSo kqtru = a.tru(b);
            PhanSo kqnhan = a.nhan(b);
            PhanSo kqchia = a.chia(b);

            Console.WriteLine("Tong hai phan so la:"+ kqcong.getTuso()+"/"+ kqcong.getMauso());
            Console.WriteLine("Hieu hai phan so la: {0}/{1}", kqtru.getTuso(), kqtru.getMauso());
            Console.WriteLine("Tich hai phan so la: {0}/{1}", kqnhan.getTuso(), kqnhan.getMauso());
            Console.WriteLine("Thuong hai phan so la: {0}/{1}", kqchia.getTuso(), kqchia.getMauso());

            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            PhanSo kqcongday = new PhanSo();
            PhanSo pscong;
            for (int i = 1; i <= n; i++)
            {
                pscong = new PhanSo(1, i);
                kqcongday= kqcongday.cong(pscong);
            }
            kqcongday.toiGian(kqcongday);
            Console.WriteLine("Tong cua cac day phan so la: {0}/{1}",kqcongday.getTuso(),kqcongday.getMauso());

            Console.ReadLine();
        }
    }
}
