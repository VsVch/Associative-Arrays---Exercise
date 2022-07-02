using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryIteams = new Dictionary<string, int>();
            legendaryIteams.Add("shards", 0);
            legendaryIteams.Add("motes", 0);
            legendaryIteams.Add("fragments", 0);
            var junkMaterials = new Dictionary<string, int>();
            bool isLendaryfound = false;
           
            

            while (!isLendaryfound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    string keyMaterial = input[i].ToLower();
                    int valueMaterial = int.Parse(input[i-1]);
                    if (keyMaterial == "shards" || keyMaterial == "motes" || keyMaterial == "fragments")
                    {

                        //if (!legendaryIteams.ContainsKey(keyMaterial))
                        //{
                        //    legendaryIteams[keyMaterial] = 0;
                        //}
                        legendaryIteams[keyMaterial] += valueMaterial;
                        if (legendaryIteams[keyMaterial] >= 250)
                        {
                            isLendaryfound = true;
                            break;
                        }
                    }
                    else if (junkMaterials.ContainsKey(keyMaterial))
                    {
                        junkMaterials[keyMaterial] += valueMaterial;
                    }
                    else
                    {
                        junkMaterials.Add(keyMaterial, valueMaterial);
                    }

                    
                }

            }

            if (legendaryIteams["shards"] >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                legendaryIteams["shards"] -= 250;
            }
            else if (legendaryIteams["fragments"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                legendaryIteams["fragments"] -= 250;
            }
            else if (legendaryIteams["motes"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                legendaryIteams["motes"] -= 250;
            }

            foreach (var keyitem in legendaryIteams)
            {
                Console.WriteLine($"{keyitem.Key}: {keyitem.Value}");
            }
            foreach (var junkitem in junkMaterials)
            {
                Console.WriteLine($"{junkitem.Key}: {junkitem.Value}");
            }



        }


        
    }
}