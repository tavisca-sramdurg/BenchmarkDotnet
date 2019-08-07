using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparison
{
    public class ForVsForeach
    {
        [Params(2)]
        public int limit;


        List<int> list1 = new List<int> { };
        List<int> list2 = new List<int> { };
        List<int> list3 = new List<int> { };

        public void loop()
        {
            for (int i = 0; i < limit; i++)
            {
                list1.Add(i);
            }
        }

        [Benchmark]
        public void LoopWithFor()
        {
            for (int iterator = 0; iterator < list1.Count; iterator++)
            {
                list2.Add(list1[iterator]);
            }
        }

        [Benchmark]
        public void LoopWithForeach()
        {
            foreach (var number in list1)
            {
                list3.Add(list1[number]);
            }
        }
    }
}
