using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Demo1
{
    class Demo1
    {
        static void Main(string[] args)
        {
            Thread objthread1 = new Thread(Method1);
            Thread objthread2 = new Thread(Method2);
            objthread1.Name = "First thread";
            objthread2.Name = "Second Thread";
            objthread1.Start();
            objthread2.Start();
            Console.ReadKey();
        }
        static void Method1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Method one Executed " + i.ToString());
               // Thread.Sleep(2000);
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Method Two Executed " + i.ToString());
                //Thread.Sleep(2000);
            }
        }
    }
}
