using System;
using System.Collections.Generic;
namespace ConsoleApp31
{


    class Program
    {

        public static List<Package> getPackagesWithWeightabove10(List<Package> packages)
        {
            List<Package> weightAbove10Packages = new List<Package>();

            foreach(Package package in packages)
            {
                if (package.Weight > 10)
                {
                    weightAbove10Packages.Add(package);
                }
            }
            return weightAbove10Packages;

        }

        public static List<Package> getPackagesWithWeightBelow10(List<Package> packages)
        {
            List<Package> weightAbove10Packages = new List<Package>();

            foreach (Package package in packages)
            {
                if (package.Weight < 10)
                {
                    weightAbove10Packages.Add(package);
                }
            }
            return weightAbove10Packages;

        }

        static void Main(string[] args)
        {

         

            List<Package> packages = new List<Package>();

            Func<List<Package>, List<Package>> filterAbove10 = new Func<List<Package>, List<Package>>(getPackagesWithWeightabove10);
            Func<List<Package>, List<Package>> filterBelow10 = new Func<List<Package>, List<Package>>(getPackagesWithWeightBelow10);


            List<string> cities = new List<string>();
            cities.Add("Osijek");
            cities.Add("Zagreb");
            cities.Add("Osijek");

            //napravite riječnik koji sadrži parove svih gradove iz liste cities i broj njihovog pojavljivanja u listi

            Dictionary<string, int> citiesNumOfCities = new Dictionary<string, int>();

             


            int numOfOccurences = 0;
            foreach(string city in cities)
            {
                foreach(string city1 in cities)
                {
                    if (city == city1)
                    {
                        numOfOccurences++;
                    }

                }
                
                if(!citiesNumOfCities.ContainsKey(city))
                    citiesNumOfCities.Add(city, numOfOccurences);

                numOfOccurences = 0;
            }

            // 

             
          

            Package p = new Package(100, "Osijek", 3);
            
            string className = p.ToString();
           
            
            Console.WriteLine(className.Split('.')[1]);
        }
    }
}
