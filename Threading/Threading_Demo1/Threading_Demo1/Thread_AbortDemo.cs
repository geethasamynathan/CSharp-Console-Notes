using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Threading_Demo1
{
    class Thread_AbortDemo
    {
        static void Main(string[] args)
        {
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread t1 = new Thread(ProcessJoin1);
            Thread t2 = new Thread(ProcessJoin2);
            t1.Start();
            t2.Start();
            t1.Abort();
            //t2.Abort();
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            //string elapsedtime = string.Format("{0:00} :{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Thread.Sleep(5000);
            Console.WriteLine( " Elapsed Time " +ts.TotalSeconds);
           // Console.ReadLine();
                
        }
        static void ProcessJoin1()
        {
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine("Work in Progress" + i);
                  Thread.Sleep(1000);
            }
        }
        static void ProcessJoin2()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Process Join" + i);
                //Thread.Sleep(5000);
            }
        }
    }
}
