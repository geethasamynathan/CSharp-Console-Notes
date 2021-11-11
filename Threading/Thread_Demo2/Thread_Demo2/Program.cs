using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Demo2
{
    class Printer
    {
        public void PrintTable1()
        {
            lock (this)
            {
               for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + ",");
                    Thread.Sleep(1000);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(p.PrintTable1);
            Thread t2 = new Thread(p.PrintTable1);
            // Thread t1 = new Thread(new ThreadStart(p.PrintTable1));
            // Thread t2 = new Thread(new ThreadStart(p.PrintTable1));
            t1.Start();
            t2.Start();
            Console.ReadLine();

        }
    }
    //public void PrintTable2()
    //{
    //    lock (this)
    //    {

    //        for (int i = 41; i <= 50; i++)
    //        {
    //            Console.WriteLine(i);
    //            Thread.Sleep(1000);
    //        }
    //    }
    //}
}
    

