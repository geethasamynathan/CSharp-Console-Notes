using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL__Samples
{
    class _7_WaitAny_Demo
    {
        static void Main(string[] args)
        {
            //creating the tasks  
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task 1 - iteration {0}", i);
                    //sleeping for 1 second  
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Task 1 complete");
            });

            Task task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 complete");
            });

            //starting the tasks  
            task1.Start();
            task2.Start();

            //waiting for the first task to complete  
            Console.WriteLine("Waiting for tasks to complete.");
            int taskIndex = Task.WaitAny(task1, task2);
            Console.WriteLine("Task Completed - array index: {0}", taskIndex);

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
