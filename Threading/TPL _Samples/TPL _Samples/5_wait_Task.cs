using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL__Samples
{
    class _5_wait_Task
    {        static void Workload()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" Task Iteration : {i}");
                Thread.Sleep(500);
            }           
        }
        static void Main(string[] args)
        {
            Task task = new Task(new Action (Workload));
            task.Start();
            Console.WriteLine("Waiting for task to complete");
           task.Wait();
            Console.WriteLine("Task completed");
            task = new Task(new Action(Workload));
            task.Start();
            Console.WriteLine(" waiting 2 secs for task complete");
            task.Wait(2000);
            Console.WriteLine("wait ended . Task completed");
            Console.WriteLine("Main method completed");
            Console.ReadLine();

        }
    }
}
