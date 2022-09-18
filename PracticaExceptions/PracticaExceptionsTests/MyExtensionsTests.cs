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
    public class MyExtensionsTests
    {
        [TestMethod()]
        public void EmptyOrLetterTest()
        {
            string n1 = "s";
            string n2 = "";
            bool esperado = true;

            var res = MyExtensions.EmptyOrLetter(n1, n2);

            Assert.AreEqual(esperado,res);
        }

        [TestMethod()]
        public void AllEmptyTest()
        {
            string n1 = "";
            string n2 = "";
            bool esperado = true;

            var res = MyExtensions.EmptyOrLetter(n1, n2);

            Assert.AreEqual(esperado, res);
        }

        [TestMethod()]
        public void AllLettersTest()
        {
            string n1 = "s";
            string n2 = "a";
            bool esperado = true;

            var res = MyExtensions.EmptyOrLetter(n1, n2);

            Assert.AreEqual(esperado, res);
        }
    }
}