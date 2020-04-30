using Course.Entities;
using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                if (c != 'i' && c != 'c')
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input, try again!");
                    Console.WriteLine();
                    i--;
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    if (c == 'c')
                    {
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                    }
                    else
                    {
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine());
                        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.TaxesPaid().ToString("F2"));
                sum += taxPayer.TaxesPaid();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2"));
        }
    }
}
