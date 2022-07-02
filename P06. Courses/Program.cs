using System;
using System.Collections.Generic;

namespace P06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> courses = new Dictionary<string, string>();
            Dictionary<string, int> countPeople = new Dictionary<string, int>();
            while (input != "end")
            {
                string[] inputvalid = input.Split(" : ");
                string courseName = inputvalid[0];
                string studentName = inputvalid[1];
                if (courses.ContainsValue(courseName) & countPeople.ContainsKey(courseName))
                {
                    countPeople[courseName] += 1;
                    courses.Add(studentName, courseName);
                    
                }
                else 
                {
                    courses.Add(studentName, courseName);
                    countPeople.Add(courseName, 1);
                }



                input = Console.ReadLine();
            }

            foreach (var item in countPeople)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                foreach (var item2 in courses)
                {
                    if (item.Key == item2.Value)
                    {
                        Console.WriteLine($"-- {item2.Key}");
                    }
                }
            }


        }
    }
}
