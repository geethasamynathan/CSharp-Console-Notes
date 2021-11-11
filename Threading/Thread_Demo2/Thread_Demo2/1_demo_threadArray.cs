using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_Demo2
{
    class _1_demo_threadArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  *********** Multiple Threads ******");
            Printer p = new Printer();
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(p.PrintTable1);
                Threads[i].Name = "Child" + i+1;
            }
            foreach (Thread t in Threads)
            {
                t.Start();
            }

            Console.ReadLine();


        }
    }
}
