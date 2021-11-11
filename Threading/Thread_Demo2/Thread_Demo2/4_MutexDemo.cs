using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_Demo2
{
    class _4_MutexDemo
    {
        private static Mutex mutex = new Mutex();
        const int numhits = 1;
        const int numThreads = 4;
        static void ProcesThread()
        {
            _4_MutexDemo objmd = new _4_MutexDemo();
            for (int i = 0; i < numhits; i++)
            {
                objmd.useSample();
            }
        }
        void useSample()
        {
             mutex.WaitOne();// wait until it is safe to enter
           // lock (this)
           // {
                Console.WriteLine(" {0} has entered ", Thread.CurrentThread.Name);
                Thread.Sleep(2000);
                Console.WriteLine("{0} has leaving", Thread.CurrentThread.Name);
                 mutex.ReleaseMutex();
            //}
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < numThreads; i++)
            {
                Thread mythread = new Thread(ProcesThread);
                mythread.Name = string.Format("Thread {0}",i+1);
                mythread.Start();
            }
            Console.ReadKey();
           

        }
    }
}
