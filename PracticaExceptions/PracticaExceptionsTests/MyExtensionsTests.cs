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
        public void EmptyTest()
        {
            string str = "";
            bool esperado = true;

            var res = str.EmptyOrLetter();

            Assert.AreEqual(esperado,res);
        }

        [TestMethod()]
        public void LetterTest()
        {
            string str = "s";
            bool esperado = true;

            var res = str.EmptyOrLetter();

            Assert.AreEqual(esperado, res);
        }

        [TestMethod()]
        public void FailTest()
        {
            string str = "35";
            bool esperado = false;

            var res = str.EmptyOrLetter();

            Assert.AreEqual(esperado, res);
        }

    }
}