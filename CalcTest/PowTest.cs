using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void PowTest1()
        {
            BinaryOperation calc = fabric.Calc("x^y");
            double rez1 = calc.Calculate(2, 1);
            Assert.AreEqual(2, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(8, 4);
            Assert.AreEqual(4096, rez2, 0.001, "Ошибка");
        }
    }
}
