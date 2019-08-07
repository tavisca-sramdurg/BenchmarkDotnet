using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PerformanceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<ForVsForeach>();
            var summary2 = BenchmarkRunner.Run<StringVsStringbuilder>();
            var summary3 = BenchmarkRunner.Run<ArrayVsList>();
            var summary4 = BenchmarkRunner.Run<TaskVsThread>();
        }
    }
}
