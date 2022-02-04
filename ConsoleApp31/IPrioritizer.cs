using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    interface IPrioritizer
    {
        public List<Package> GetlargerThanAvgWeight(List<Package> packages);

        public List<string> GetMaxPriorityCities(List<Package> packages);
    }
}
