using PolimorfismEx1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolimorfismEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced (y/n) :");
                char outsourced = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Hours : ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour :");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(outsourced == 'y')
                {
                    Console.Write("Additional charge : ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name,hours,valuePerHour,additionalCharge));
                }
                else if(outsourced == 'n')
                {
                    employees.Add(new Employee(name,hours,valuePerHour));
                }
                else
                {
                    Console.WriteLine("Incorrect Value.");
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS : ");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadKey();
        }
    }
}
