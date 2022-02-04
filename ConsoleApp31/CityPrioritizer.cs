using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    class CityPrioritizer<T>: IPrioritizer
    {

        List<string> cities = new List<string>();

        public void AddCity(string city) => cities.Add(city);


        public List<Package> GetlargerThanAvgWeight(List<Package> packages)
        {
            List<Package> largerThanAvgPackages = new List<Package>();

            double weightSum = 0;
            foreach (Package package in packages)
            {
                weightSum += package.Weight;
            }

            double avgWeight = weightSum / packages.Count;

            foreach(Package package in packages)
            {
                if(package.Weight>avgWeight && cities.Contains(package.City))
                {
                    largerThanAvgPackages.Add(package);

                }
            }
            return largerThanAvgPackages;
            
        }


        public List<Package> GetPackages(List<Package> packages, Func<List<Package>, List<Package>> Filter)
        {
            return Filter(packages);

        }

   





        public List<string> GetMaxPriorityCities(List<Package> packages)
        {
            List<string> maxPriorityCities = new List<string>();


            int maxPriority = 0;

            foreach(Package package in packages)
            {
                if (package.Priority > maxPriority)
                {
                    maxPriority = package.Priority;
                }
            }


            foreach(Package package in packages)
            {
                if(package.Priority==maxPriority && cities.Contains(package.City) && !maxPriorityCities.Contains(package.City))
                {
                    maxPriorityCities.Add(package.City);

                }
            }

            return maxPriorityCities;



        }
    }
}
