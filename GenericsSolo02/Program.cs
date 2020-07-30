using System;
using System.Collections.Generic;
using GenericsSolo02.Entities;
using GenericsSolo02.Service;

namespace GenericsSolo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(',');
                string name = value[0];
                double price = double.Parse(value[1]);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product products = calculationService.Max(list);

            Console.WriteLine("Max: ");

            products.ToString();

        }
    }
}
