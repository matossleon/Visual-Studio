using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            Employee employee;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char outSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (outSourced == 'y')
                {
                    Console.Write("Addtional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, addtionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            foreach (Employee  emp in employees)
            {
               Console.WriteLine(emp);
            }
        }
    }
}

