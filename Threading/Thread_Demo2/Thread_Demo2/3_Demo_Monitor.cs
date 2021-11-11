using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_Demo2
{
    class printer3
    {  

            public void print()
            {
          //  lock(this)
            Monitor.Enter(this);
           try

            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(i + ",");
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
    class _3_Demo_Monitor
    {
        static void Main(string[] args)
        {
            printer3 p3 = new printer3();
            Thread t1 = new Thread(p3.print);
            Thread t2 = new Thread(p3.print);
            t1.Start();
            t2.Start();
            Console.ReadLine();

        }
    }
}
