using System;
using System.Collections.Generic;

namespace P05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingCars = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
               


                if (command == "register")
                {
                    string username = input[1];
                    string licensePlateNumber = input[2];
                    if (!parkingCars.ContainsKey(username))
                    {
                        parkingCars.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else if (parkingCars.ContainsKey(username) & parkingCars.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                   
                }
                else if (command == "unregister")
                {
                    string username = input[1];
                    
                    if (!parkingCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingCars.Remove(username);
                    }

                }

            }
            foreach (var item in parkingCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
