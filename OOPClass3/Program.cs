using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1000);
            Account account2 = new Account(500);
            Console.WriteLine($"Initial Balance: {account1.Balance}");
            Console.WriteLine($"Initial Balance: {account2.Balance}");
            account1.Credit(200);
            if(account2.Debit(100))
            {
                Console.WriteLine("Debit successful.");
            }
            else
            {
                Console.WriteLine("Debit failed.");
            }
            account2.Debit(100);
            Console.WriteLine($"Updated Balance: {account1.Balance}");
            Console.WriteLine($"Updated Balance: {account2.Balance}");
            if(account1.Debit(1500))
            {
                Console.WriteLine("Debit successful.");
            }
            else
            {
                Console.WriteLine("Debit failed.");
            }
        }
    }
}