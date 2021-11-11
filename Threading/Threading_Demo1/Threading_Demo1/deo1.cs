using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Demo1
{
    class deo1
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(new ThreadStart(Method2));
            thread1.Start();
            thread2.Start();
            Console.WriteLine(" Main Thread");
            Console.ReadLine();
        }
        static void Method1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Method 1 " +i);
                Thread.Sleep(2000);
            }
        }
        static void Method2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Method 2 executed " + i);
                Thread.Sleep(2000);
            }
        }
    }
}
