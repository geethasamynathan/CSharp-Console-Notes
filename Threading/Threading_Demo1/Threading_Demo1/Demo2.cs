using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Demo1
{
    class Demo2
    {
        static void Main(string[] args)
        {
            Thread objworkerthread = new Thread(workerThread);
            objworkerthread.Start();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Main Thread ");
                Thread.Sleep(2000);                
            }
            Console.ReadKey();
        }
        static void workerThread()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("worker Thread " +i);
              //  Thread.Sleep(2000);
            }
        }
    }
}
