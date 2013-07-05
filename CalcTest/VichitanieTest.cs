using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class VichitanieTest
    {
        [TestMethod]
        public void VichitanieTest1()
        {
            BinaryOperation calc = fabric.Calc("-");
            double rez1 = calc.Calculate(2, 1);
            Assert.AreEqual(1, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(5.98, 10.43);
            Assert.AreEqual(-4.45, rez2, 0.001, "Ошибка");
        }
    }
}
