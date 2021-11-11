using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Different Approaches to create a Task and start

            ///The most direct way
            /*
             Task.Factory.StartNew(() => Console.WriteLine("Hello Task Library"));
            Console.ReadLine();
            */
           /* 
            //Using Action
            Task task = new Task(new Action(PrintMessage));
            task.Start();

            */
            
             //Using a delegate
             Task task = new Task(delegate { PrintMessage(); });
             task.Start();
             
             /*
             //Lambda and named method
             Task task = new Task(() => PrintMessage());
             task.Start();
            
            // Lambda and anonymous method
            Task task1 = new Task(() => { PrintMessage(); });
            task.Start();
            */
           
           // Task.Factory.StartNew( ()=>DoWork());
            Task t2 = Task.Run(() =>
            {
                Console.WriteLine(" Demo of  Task.Run()");
            });
           // t2.Start();
            Console.ReadKey();
        }

        static private void PrintMessage()
        {
            Console.WriteLine("Hello Task library!");
        }
        //Using Task.Run in .NET4.5
          public static async Task DoWork()
          {
              await Task.Run(() => PrintMessage());
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
