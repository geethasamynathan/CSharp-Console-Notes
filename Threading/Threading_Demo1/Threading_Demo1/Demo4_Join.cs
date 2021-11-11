using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Demo1
{
    class Demo4_Join
    {
        static void Main(string[] args)
        {
            Thread objThread = new Thread(ProcessJoin);
            Thread thread2 = new Thread(ProcessJoin2);
            thread2.Start();
            objThread.Start();        
            thread2.Join();                   
            Console.WriteLine("Work Completed");
            Console.ReadKey();
        }
        static void ProcessJoin()
        {
            for (int i = 1; i < 80; i++)
            {
                Console.WriteLine("Work in Progress"+i);
              //  Thread.Sleep(1000);
            }
        }
        static void ProcessJoin2()
        {
            for (int i = 1; i < 80; i++)
            {
                Console.WriteLine("Process Join"+i);
                //Thread.Sleep(1000);
            }
        }
    }
}
