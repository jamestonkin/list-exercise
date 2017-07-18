using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4));

            planetList.Remove("Pluto");

            foreach(string rocky in rockyPlanets)
            {
                Console.WriteLine(rocky);
            }

            foreach(string planets in planetList)
            {
                Console.WriteLine(planets);
            }
            Console.Read();
        }
    }
}
