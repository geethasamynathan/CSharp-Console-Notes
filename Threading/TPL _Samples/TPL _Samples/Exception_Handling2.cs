using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Exception_Handling2
    {
        static void Main(string[] args)
        {
            try
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Digging in progress ");
                    Task childtask = Task.Factory.StartNew(() =>
                   {
                       Console.WriteLine("Remove stones");
                       throw new Exception("Something went wrong");
                   }, TaskCreationOptions.AttachedToParent);
                    throw new Exception("Tools crashed");
                });              
                t1.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var item in ae.Flatten().InnerExceptions)
                {
                    Console.WriteLine("Stop the work and notify others :" + item.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
