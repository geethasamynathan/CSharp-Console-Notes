using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo
{
    public delegate void EventHadler();
    class Program
    {
        public static event EventHadler _Show;
        static void Main(string[] args)
        {
            _Show += new EventHadler(Cat);
            _Show += new EventHadler(Dog);
            _Show.Invoke();
            Console.ReadLine();
        }
        public static  void Cat()
        {
            Console.WriteLine(" Hi this is Cat" );
        }
        public static  void Dog()
        {
            Console.WriteLine("I am dog");
        }
    }
}
