using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Exception_Handling3
    {
        static void Main(string[] args)
        {
            try
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int index = 0; index < 5; index++)
                    {
                        Console.WriteLine("Digging completed for " + index + "mts. area ");
                    }
                    Task childtask = Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Remove stones");

                        throw new Exception("Something went wrong");

                    }, TaskCreationOptions.AttachedToParent);
                    throw new Exception("Tools crashed");
                });

                Task t2 = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Clean the area");
                    for (int index = 0; index < 5; index++)
                    {
                        Console.WriteLine("Cleaning....");
                    }
                    throw new Exception("Problem occured");
                });

                Task.WaitAll(t1, t2);
            }
            catch (AggregateException ae)
            {
                foreach (var item in ae.Flatten().InnerExceptions)
                {
                    Console.WriteLine("Stop the work and notify others :" + item.Message);
                }
            }
            
        }
    }
}
