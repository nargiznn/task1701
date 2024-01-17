using System;
using System.Xml.Linq;

namespace task1701
{
    class Program
    {
        static void Main(string[] args)
        {
 
            ChineCity city1 = new ChineCity { Name = "Shangha", Population = 24890000 };
            ChineCity city2 = new ChineCity { Name = "Beijing ", Population = 21893095 };
            City city3 = new City { Name = "Baku", Population = 10440215 };
            City city4 = new City { Name = "Gence", Population = 800000 };
            ChineCity[] chineCities = { city1, city2 };
            double avgPopulation = ChineavgPopulation(chineCities);

            Console.WriteLine($"City avg: {avgPopulation}");
        }

        static double ChineavgPopulation(ChineCity[] cities)
        {
            int totalPopulation = 0;
            foreach (var city in cities)
            {
                totalPopulation += city.Population;
            }

            return cities.Length > 0 ? (double)totalPopulation / cities.Length : 0;
        }
    }
}
    


