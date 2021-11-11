using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class _1_SimpleTask
    {
        static void HelloConsole()
        {
            Console.WriteLine("Hello Task!");
        }
        static void Main(string[] args)
        {
            Task task1 = new Task(new Action(HelloConsole));
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });
            Task task3 = new Task(() => HelloConsole());
            task1.Start();
            task2.Start();
            task3.Start();
            Console.WriteLine("Main method Complete");
            Task.Factory.StartNew(() => HelloConsole());
            Console.ReadLine();
        }
    }
}
