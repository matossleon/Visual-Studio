using System;
using System.Collections.Generic;
using Course.Entities;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                if ((type != 'c') && (type != 'u') && (type != 'i'))
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida, tente novamente");
                    i--;
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    if (type == 'c')
                    {
                        products.Add(new Product(name, price));
                    }
                    else if (type == 'u')
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        products.Add(new UsedProduct(name, price, manufactureDate));
                    }
                    else
                    {
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customsFee));
                    }
                }
            }

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
