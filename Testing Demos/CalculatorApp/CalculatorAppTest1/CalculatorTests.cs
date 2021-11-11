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
        public void PlusTest()
        {
            int num1 = 10;
            int num2 = 5;
            int expectedresult = num1 + num2;
            Calculator calci = new Calculator();
            int actualresult = calci.Plus(num1,num2);
            Assert.AreEqual(expectedresult, actualresult);
            //, "ExpectedResult was{0} using a={1} and b={1} but actualresult was {3}", expectedresult, num1, num2, actualresult
        }
    }
}