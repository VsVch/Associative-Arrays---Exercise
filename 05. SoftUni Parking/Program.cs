using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> counts = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string enteringOrLeaving = tokens[0];
                if (tokens[0] == "register")
                {
                    string name = tokens[1];
                    string plateNumber = tokens[2].ToString();

                    if (counts.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else if (counts.ContainsKey(name) == false)
                    {
                        counts.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                }
                else if (tokens[0] == "unregister")
                {
                    string name = tokens[1];
                    if (counts.ContainsKey(name) == false)
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else if (counts.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        counts.Remove(name);
                    }
                }
            }
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}