using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var ch in inputs)
            {
                if (counts.ContainsKey(ch))
                {
                    counts[ch]++;
                }
                else
                {
                    counts.Add(ch, 1);
                }
            }
            foreach (var item in counts.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            

        }
    }
}
