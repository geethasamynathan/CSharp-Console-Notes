using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace Threading_Demo1
{
    class Demo5_Sleep
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread objthread = new Thread(ProcessJoin);
            Thread objthread2 = new Thread(ProcessJoin2);
            objthread.Start();
            objthread2.Start();
            objthread.Join();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine(" Total Time Elapsed " +elapsedTime);

            Console.WriteLine(" Work Completed..");
            Console.ReadLine();


        }
        public static void ProcessJoin()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Work in Progress !");
                Thread.Sleep(4000);
            }
        }
        public static void ProcessJoin2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Work in Progress 2 !");
                Thread.Sleep(4000);
            }
        }
    }
}
