
using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> final = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (!final.ContainsKey(ch))
                {
                    final.Add(ch, 1);
                }
                else if (final.ContainsKey(ch))
                {
                    final[ch]++;
                }

            }

            foreach (KeyValuePair<char, int> ch in final.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }

        }
    }
}
