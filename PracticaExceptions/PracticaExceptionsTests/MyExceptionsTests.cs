using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions.Tests
{
    [TestClass()]
    public class MyExceptionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division1Test()
        {
            decimal n1 = 24;
            decimal n2 = 0;

            MyExceptions.Division1(n1,n2);

        }

        [TestMethod]
        public void Division1TestResult()
        {
            decimal n1 = 35;
            decimal n2 = 5;
            decimal esperado = 7;

            var res = MyExceptions.Division1(n1,n2);

            Assert.AreEqual(esperado,res);
        }
    }
}