using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestCalculation()
        {
            BinaryOperation calc = fabric.Calc("+");
            double rez = calc.Calculate(2.0,1.0);
            Assert.AreEqual(3, rez, 0.001, "Ошибка");
        }
    }
}
