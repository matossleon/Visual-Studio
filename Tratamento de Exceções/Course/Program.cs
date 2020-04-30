using Course.Entities;
using Course.Entities.Exceptions;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, initialBalance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
