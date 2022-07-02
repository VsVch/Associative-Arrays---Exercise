using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGardes = new Dictionary<string, List<double>>();
            string name;
            double grade = 0;



            for (int i = 0; i < n; i ++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                

                if (!studentsGardes.ContainsKey(name))
                    {
                        studentsGardes.Add(name, new List<double>());
                    }


                studentsGardes[name].Add(grade);

            }

            foreach (var item in studentsGardes.Where(v => v.Value.Average() >= 4.5))
            {
                
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }


        }
    }
}
