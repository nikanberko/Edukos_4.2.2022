using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    class PackageContainer
    {
        private List<Package> packages;

        public PackageContainer()
        {
            packages = new List<Package>();

        }

        public void AddPackage(Package package)
        {
            packages.Add(package);

        }
        
        public double getTotalWeight(int priority)
        {
            double totalWeight = 0;
            foreach(Package package in packages)
            {
                if (package.Priority == priority)
                {
                    totalWeight += package.Weight;
                }
            }
            return totalWeight;
        }





    }
}
