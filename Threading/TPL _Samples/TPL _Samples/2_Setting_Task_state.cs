using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class _2_Setting_Task_state
    {
        static void Helloconsole(object message)
        {
            Console.WriteLine($" Hello :{message}" );
        }
        static void Main(string[] args)
        {

            Task task1 = new Task(new Action<object>(Helloconsole), " Task 1");
            Task task2 = new Task(delegate (object obj)
              {
                  Helloconsole(obj);
              }, "Task 2"
              );
            Task task3 = new Task(obj => Helloconsole(obj), "Task 3");
            task1.Start();
            task2.Start();
            task3.Start();
            Console.WriteLine("Main method Complete");
            Console.ReadLine();
        }
    }
}
