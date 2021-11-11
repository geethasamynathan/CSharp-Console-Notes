using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Demo1
{
    class Demo6_Foreground
    {
        static void Main(string[] args)
        {
            Thread objworkerthread = new Thread(WorkerThread);
            objworkerthread.Start();
            objworkerthread.IsBackground = true;
            Console.WriteLine(" Main Thread Quits");
          //  objworkerthread.Abort();            
            Console.ReadLine();
        }

        static void WorkerThread()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Worker Thread in Progress ");
                Thread.Sleep(2000);
            }
            Console.WriteLine(" Worker thread Completed" );
        }
    }
}
