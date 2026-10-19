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
            //
            //Exercise 3
            //
            /*Account account1 = new Account(1000);
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
            }*/

            //
            //Exercise 4
            //
            
            Contact contact1 = new Contact("john@example.com", "123-456-7890", "123 Main St");
            Employee employee1 = new Employee(1, "John Doe", position.Manager);
            employee1.EmployeeContact = contact1;
            Console.WriteLine(employee1.DisplayEmployeeInfo());
        }
    }
}