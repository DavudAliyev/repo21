using System;
using City;
using ChinaCity;
using System.Xml.Linq;

namespace Homework_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChinaCity city1= new ChinaCity(50);
            ChinaCity city2= new ChinaCity(200);

            string countStr;
            int count;

            do
            {
                Console.WriteLine("City count: ");
                countStr = Console.ReadLine();
            }while(!int.TryParse(countStr, out count) || count<0);

            ChinaCity[] cities = new ChinaCity[count];

            Console.WriteLine("Enter cities: ");

            for (int i = 0; i < cities.Length; i++)
            {
                string name;
                do
                {
                    Console.WriteLine($"{i + 1}.Name: ");
                    name = Console.ReadLine();
                } while (CheckName(name));

                string populationStr;
                int population;

                do
                {
                    Console.WriteLine($"{i + 1}.Population: ");
                    populationStr = Console.ReadLine();
                }while (!int.TryParse(populationStr, out population) || population<100000);

                ChinaCity city = new ChinaCity(10)
                {
                    Name = name,
                    Population = population
                };

                cities[i] = city;
            }

            Console.WriteLine(PopulationAvg(cities));
        }

        static int PopulationAvg(ChinaCity[] cities)
        {
            int total = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                total += cities[i].Population;
            }

            int result = cities.Length == 0 ? 0 : total / cities.Length;
            return result;
        }

        static bool CheckName(string name)
        {
            if (String.IsNullOrWhiteSpace(name)) return false;

            if (name.Length < 3 || name.Length > 20) return false;

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLetter(name[i]))
                    return false;
            }
            return true;
        }
    }
}
