using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPO_LAB7_DZ
{
    internal class BankAccount
    {
        public string AccountNumber;
        private decimal Balance = 0;
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                
                Balance += amount;
                Console.WriteLine($"Пополнение: {amount}. Баланс: {Balance}");
            }
        }
        public void snatie(decimal amount)
        {
            if (amount > 0 &&amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"снятие {amount}");
            }
            else Console.WriteLine("Недостаточно средств");
        }
        public void printinfo()
        {
            Console.WriteLine($"Баланс {Balance}");
        }


    }
}
