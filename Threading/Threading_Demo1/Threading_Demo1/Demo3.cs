using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Demo1
{
    class Demo3
    {
        private bool sharedata;
        static void Main(string[] args)
        {
            Demo3 d3 = new Demo3();
            Thread objthread = new Thread(d3.Company1);
            objthread.Start();
            d3.Company2();
            Console.ReadKey();
        }
        public void Company1()
        {
            if (!sharedata)
            {
                sharedata = true;
                Console.WriteLine(" Data Shared company 1");

            }
        }
        public void Company2()
        {
            if (!sharedata)
            {
                sharedata = true;
                Console.WriteLine(" Data Shared company 2");

            }
        }
    }
}
