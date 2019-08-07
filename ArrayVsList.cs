using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparison
{
    public class ArrayVsList
    {
        [Params(2)]
        public int countNumber { get; set; }
        public int[] intArray;
        public List<int> intList = new List<int>();
        [Benchmark]
        public void AddNumberInArray()
        {
            intArray = new int[countNumber];
            int i = 0;
            while (i < countNumber)
            {
                intArray[i] = i;
                i++;
            }
        }
        [Benchmark]
        public void AddNumberInList()
        {
            for (int i = 0; i < countNumber; i++)
            {
                intList.Add(i);
            }
        }
    }
}
