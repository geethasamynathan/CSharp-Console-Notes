using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Parallel_For_Local_Variable
    {
        static void Main(string[] args)
        {
            int[] nums = Enumerable.Range(0, 3).ToArray();
            long total = 0;
            Parallel.For(0, nums.Length, () => 5, (j, loop, subtotal) =>
            {
               // Console.WriteLine("j" +j);
                subtotal += nums[j];
              //  Console.WriteLine(" Subtotal " +subtotal);
                return subtotal;
            },
           (x) => Interlocked.Add(ref total, x)
            );
            Console.WriteLine("The Total : " + total);

            Console.ReadKey();
        }
    }


}

