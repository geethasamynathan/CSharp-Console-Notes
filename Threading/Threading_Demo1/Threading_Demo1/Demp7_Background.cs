using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Demo1
{
    class Demp7_Background
    {
        static void Main(string[] args)
        {
        
            //Thread objthread = new Thread(Workerthread);
            //objthread.Start();
            //objthread.IsBackground = true;

            //Console.WriteLine(" Main thread Quits" );
            //for(int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Main thread in Progress");
            //  // Thread.Sleep(2000);
            //}
            // Console.ReadLine();
        }
        public static void Workerthread()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine( "Worker thread in Progress");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Worker Thread Completed" );
        }
    }
}
