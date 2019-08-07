using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparison
{
    public class TaskVsThread
    {
        [Params(2)]
        public int limit;

        public static void SaveData(int limit)
        {
            for (int iterator = 0; iterator < limit; iterator++)
            {

            }
        }

        public static void PrintData(int limit)
        {
            for (int iterator = 0; iterator < limit; iterator++)
            {

            }
        }



        [Benchmark]
        public void ExecuteWithThreads()
        {

            Thread thread1 = new Thread(() => SaveData(limit));
            Thread thread2 = new Thread(() => PrintData(limit));

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }



        [Benchmark]
        public void ExecuteWithTasks()
        {

            Task.Run(async () =>
            {
                var task1 = SaveData();
                var task2 = PrintData();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();


        }


        public async static Task SaveData()
        {
            //Thread.Sleep(4000);
            await Task.Delay(4000);
            //Console.WriteLine("SaveData");

        }

        public async static Task PrintData()
        {

            //Thread.Sleep(3000);
            await Task.Delay(4000);
            //Console.WriteLine("PrintData");
        }
    }
}
