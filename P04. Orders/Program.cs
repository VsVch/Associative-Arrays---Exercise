using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double[]> orderProducts = new Dictionary<string, double[]>();


            while (input != "buy")
            {
                string[] inputProducts = input.Split();
                string name = inputProducts[0];
                double price = double.Parse(inputProducts[1]);
                double quantity = double.Parse(inputProducts[2]);

                
                if (!orderProducts.ContainsKey(name))
                {
                    orderProducts.Add(name, new double[2]);
                }
                

                orderProducts[name][0] = price;
                orderProducts[name][1] += quantity;



                input = Console.ReadLine();
            }



            foreach (var item in orderProducts)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }

        }
    }
}
