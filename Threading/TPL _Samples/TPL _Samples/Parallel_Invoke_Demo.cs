using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Parallel_Invoke_Demo
    {
        static void Main(string[] args)
        {

            // this is strainght forward implementation
            Parallel.Invoke(() =>
           {
               Console.WriteLine("Begin First Task");
               
           },
           ()=>
           {
               Console.WriteLine(" Begin Second Task");
           },
           () =>
           {
               Console.WriteLine(" Begin third Task");
           });
            Console.WriteLine(" Parallel Task Completed");
            Console.ReadLine();
        }
    }
}
