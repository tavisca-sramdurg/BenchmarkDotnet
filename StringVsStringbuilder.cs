using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparison
{
    public class StringVsStringbuilder
    {
        [Params(2)]
        public int limit;

        [Benchmark]
        public void ConcatString()
        {
            string sampleString1 = "Hello";
            string sampleString2 = "World";
            for (int iterator = 0; iterator < limit; iterator++)
            {
                sampleString1 = string.Concat(sampleString1, sampleString2);
            }
        }

        [Benchmark]
        public void AppendStringBuilder()
        {
            StringBuilder sampleStringBuilder1 = new StringBuilder("Hello");
            StringBuilder sampleStringBuilder2 = new StringBuilder("World");
            for (int iterator = 0; iterator < limit; iterator++)
            {
                sampleStringBuilder1.Append(sampleStringBuilder2);
            }
        }
    }
}
