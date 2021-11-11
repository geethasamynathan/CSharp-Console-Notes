using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class return_input_param
    {
        static void Main(string[] args)
        {
            /*  Task<int> task = new Task<int>(obj =>
                {
                    int total = 0;
                    int max = (int)obj;
                    for (int i = 0; i < max; i++)
                    {
                        total += i;

                    }
                    return total;
                },250);
              Console.WriteLine("Main ");
                 task.Start();
              int res = Convert.ToInt32(task.Result);
              Console.WriteLine($"sum from 1 to 250={res}");
              */
            Task.Run(() => dosomework(12, 23));
           
            Console.ReadLine();


        }
        public static async Task dosomework(int n1, int n2)
        {
            int res = await Task.FromResult<int>(Getsum(n1, n2));
            Console.WriteLine("Result =" + res);
        }
        static int Getsum(int a, int b)
        {
            return a + b;
        }
    }
}
