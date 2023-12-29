using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string id;
        private string name;
        private int balance;

        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBlance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Thanh toan khong thanh cong!");
        }
        public void tranferTo(Account account, int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                account.balance += amount;
            }
            else
                Console.WriteLine("Chuyen tien khong thanh cong. So du khong du!");
        }
    }
}
