using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class _3_Task_Result
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(() =>
                {
                    int result = 1;
                    for (int i = 1; i < 5; i++)
                    {
                        result += i;
                    }
                    return result;
                });
            task.Start();
            Console.WriteLine($"Task Result  : {task.Result}");
            Console.ReadLine();
        }
    }
}
