using System;
using System.Collections.Generic;

namespace PP02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            Dictionary<string, decimal> counts = new Dictionary<string, decimal>();
            while (input != "stop")
            {
                decimal amount = decimal.Parse(Console.ReadLine());
                //if resource exists
                if (counts.ContainsKey(input))
                {
                    counts[input] += amount;
                }
                //if resource does not exists
                else
                {
                    counts[input] = amount;
                }



                input = Console.ReadLine();
            }
            foreach (string key in counts.Keys)
            {
                Console.WriteLine($"{key} -> {counts[key]}");
            }
        }
    }
}
