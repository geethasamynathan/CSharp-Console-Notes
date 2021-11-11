using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Traditional_ForLoopDemo
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");
            fruits.Add("Date");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Guava");
            fruits.Add("Jack-fruit");
            fruits.Add("Kiwi fruit");
            fruits.Add("Lemon");
            fruits.Add("Lime");
            fruits.Add("Lychee");
            fruits.Add("Mango");
            fruits.Add("Melon");
            fruits.Add("Olive");
            fruits.Add("Orange");
            fruits.Add("Papaya");
            fruits.Add("Plum");
            fruits.Add("Pineapple");
            fruits.Add("Pomegranate");

            Console.WriteLine("Printing list using foreach loop\n");

            var stopWatch = Stopwatch.StartNew();
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            }
            double FirstloopTime = stopWatch.Elapsed.TotalSeconds;
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("Printing list using Parallel.ForEach");


            stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            }
            );
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            double secondloopTime = (int)stopWatch.Elapsed.TotalSeconds;
            double timedifference = FirstloopTime - secondloopTime;
            Console.WriteLine("\n\n Time Difference "+timedifference);
            Console.Read();
        }
    }
}
