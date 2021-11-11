using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadLine();
        }
        static void Method1()
        {
            for (int i =1 ; i <=10; i++)
            {
                Console.WriteLine( "Method one Executed " +i.ToString());
            }
        }
        static void Method2()
        {
            for (int i = 31; i <= 40; i++)
            {
                Console.WriteLine("Method Two Executed " + i.ToString());
            }
        }
    }
}
