using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Demo2
{
    class EventDemo
    {
        public delegate void EventHandler();
        static event EventHandler _show;
        static void Main(string[] args)
        {
           _show += new EventHandler(Cat);
            _show += new EventHandler(Dog);
            Console.WriteLine(" Multicast Delegate" );
            _show.Invoke();
            _show -= new EventHandler(Cat);
            Console.WriteLine(" Single Cast Delegate");
            _show.Invoke();
            Console.ReadLine();
        }
        static void Cat()
        {
            Console.WriteLine(" I am Cat");
        }
        static void Dog()
        {
            Console.WriteLine("I am Dog");
        }
    }
}
