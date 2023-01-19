using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zoo> listOfZooes = new List<Zoo>();
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "Stop") break;

                    string[] combined = input.Split('-').ToArray();
                    string[] inputZoo = combined[0].Split().ToArray();
                    string[] animal = combined[1].Split().ToArray();
                    Zoo zoo = new Zoo(inputZoo[0], int.Parse(inputZoo[1]));

                    for (int i = 0; i < animal.Length; i += 2)
                    {
                        Animals currentAnimal = new Animals(animal[i], int.Parse(animal[i + 1]));
                        zoo.Animals.Add(currentAnimal);
                    }
                    listOfZooes.Add(zoo);
                    
                    List<Zoo> sorted =listOfZooes.OrderBy(x => x.ZooName)
                        .ThenBy(x => x.Capacity)
                        .ThenBy(x => x.Animals.Count)
                        .ToList();
                    foreach (var item in sorted)
                    {
                        Console.WriteLine(item.ToString());
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}