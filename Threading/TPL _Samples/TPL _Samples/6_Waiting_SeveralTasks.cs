using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL__Samples
{
    class _6_Waiting_SeveralTasks
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() =>
             {
                 for (int i = 0; i < 5; i++)
                 {
                     Console.WriteLine($" Task1  = Iteraation {i}");
                     Thread.Sleep(1000);
                 }
                 Console.WriteLine(" Task 1 - completed");
             });
            Task task2 = new Task(() =>
              {
                  Console.WriteLine("Task 2 complete");
              });
            task1.Start();
            task2.Start();
            Console.WriteLine("Waiting for tasks to complete");
            Task.WaitAll(task1, task2);
            Console.WriteLine(" Tasks Complete");
            Console.WriteLine(" Main method Complete");
            Console.ReadLine();
        }
    }
}
