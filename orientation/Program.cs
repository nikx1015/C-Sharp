using System;
using System.Collections.Generic;

namespace orientation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string tacoShop = "Tacos";
            string tacoAddress = "Taco Ave";
            double tacoBudget = 1200.00;
            bool tacoOpen = true;
            int numberOfTacoEmployees = 10;
            int numberOfMenuItems = 15;

            Console.WriteLine($"{tacoShop} sells {numberOfMenuItems} types of tacos on {tacoAddress}");

            List<string> employees = new List<string>(){
                "Andy", "Nikki", "Jin"
            };

            foreach (string singleEmployee in employees)
            {
                if (singleEmployee == "Nikki")
                {
                    Console.WriteLine($"{singleEmployee} is the best employee, evar!");
                }
                else
                {
                    Console.WriteLine($"I guess {singleEmployee} is okay.");
                }
            }
            employees.Add("Loki");
            employees.Insert(4, "Nyx");

            Console.WriteLine(employees.Count);

            List<string> customers = new List<string>(){
            "Kim", "Jordan"
        };

            string newCustomer = customers.Find(customer => customer == "Kim");
            Console.WriteLine(newCustomer);

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");
            List<string> otherPlanets = new List<string>(){
        "Uranus", "Neptune"
    };

            planetList.AddRange(otherPlanets);
            foreach (string singlePlanet in planetList)
            {
                Console.WriteLine(singlePlanet);
            }
           List<string> rockyPlanet = planetList.GetRange(0, 4);
            foreach(string singleRockyPlanet in rockyPlanet)
            {
                Console.WriteLine(singleRockyPlanet);
            }

            Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};
for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

}
        }
    }
}
