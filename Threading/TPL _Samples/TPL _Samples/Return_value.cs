using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Return_value
    {
        static void Main(string[] args)
        {

            Task<int> task = new Task<int>(() =>
              {
                  Console.WriteLine("worker task");
                  int total = 0;
                  for (int i = 0; i < 500; i++)
                  {
                      total += i;
                  }
                  return total;
              });
            Console.WriteLine("Main thread ");
            task.Start();
            int res =Convert.ToInt32( task.Result);
            Console.WriteLine("Result " +res);
            Console.ReadLine();
        }
    }
}
