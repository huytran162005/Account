using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so ID muon tao (tk1): ");
            string id = Console.ReadLine();
            Console.Write("Nhap Ten (tk1): ");
            string name = Console.ReadLine();
            Account my = new Account(id, name, 0);

            Console.Write("Nhap so ID muon tao (tk2): ");
            string id2 = Console.ReadLine();
            Console.Write("Nhap Ten (tk2): ");
            string name2 = Console.ReadLine();
            Account account2 = new Account(id2, name2, 0);
            Console.WriteLine("Thong tin tai khoan da tao: ");
            Console.WriteLine("Thong tin tai khoan 1:[ID: {0}, Name: {1}, Balance: {2}] "
                , my.getID(), my.getName(), my.getBlance());
            Console.WriteLine("Thong tin tai khoan 2:[ID: {0}, Name: {1}, Balance: {2}] "
                , account2.getID(), account2.getName(), account2.getBlance());
            Console.WriteLine("Nhap so tien muon nap(tk1): ");
            int amountnap = int.Parse(Console.ReadLine());
            my.credit(amountnap);
            Console.WriteLine("Nhap so tien muon rut (tk1): ");
            int amountrut = int.Parse(Console.ReadLine());
            my.debit(amountrut);
            Console.WriteLine("Nhap so tien muon chuyen(tk1->tk2): ");
            int amountchuyen = int.Parse(Console.ReadLine());
            my.tranferTo(account2,amountchuyen);

            Console.WriteLine("Thong tin tai khoan sau khi thuc hien hanh vi: ");
            Console.WriteLine("Thong tin tai khoan 1:[ID: {0}, Name: {1}, Balance: {2}] "
                , my.getID(), my.getName(), my.getBlance());
            Console.WriteLine("Thong tin tai khoan 2:[ID: {0}, Name: {1}, Balance: {2}] "
                , account2.getID(), account2.getName(), account2.getBlance());
            Console.ReadLine();
            
            

        }
    }
}
