using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;

namespace Seção_6___Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list;
            list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            Employee[] idRep = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee: " + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Employee testId = list.Find(x => x.Id == id);
                if (testId == null)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salário: ");
                    double salary = double.Parse(Console.ReadLine());
                    list.Add(new Employee(id, name, salary));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The typed Id is already in use, please try again!");
                    Console.WriteLine();
                    i--;
                }
            }

            Console.Write("Enter the employee id that will have increased salary : ");
            int increaseId = int.Parse(Console.ReadLine());
            Employee empIncrease = list.Find(x => x.Id == increaseId);
            if (empIncrease != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                empIncrease.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist");
            }



            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }       
    }
}
