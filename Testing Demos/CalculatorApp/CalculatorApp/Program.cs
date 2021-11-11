using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
   public class Calculator
    {
        public int num1, num2;
        public int  Plus(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            return num1+num2;
        }
        public int Minus(int a, int b)
        {
            return a + b;
        }
        public int Division(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
           
            c.Plus(10,10);
        }
    }
}
