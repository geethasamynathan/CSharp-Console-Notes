using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Parallel_For_Loop_Demo
    {
        static int[] _values = Enumerable.Range(0, 1000).ToArray();

        static void Example(int x)
        {
            // Sum all the elements in the array.
            int sum = 0;
            int product = 1;
            foreach (var element in _values)
            {
                sum += element;
                product *= element;
            }
        }
        static void Main()
        {
            const int max = 10;
            const int inner = 100000;
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                Parallel.For(0, inner, Example);
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                for (int z = 0; z < inner; z++)
                {
                    Example(z);
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.Read();
        }
    }
}
