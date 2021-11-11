using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void PlusTest(int a, int b)
        {
            Calculator calci = new Calculator();
            int expectedresult = a + b;
            int actualresult = calci.Plus(a, b);
            Assert.AreEqual(expectedresult, actualresult, "The expected result was {0} ,using a={1} and b= {2} , but the actual result was {3} ", expectedresult, a, b, actualresult);
          //  Assert.Fail();
        }
    }
}