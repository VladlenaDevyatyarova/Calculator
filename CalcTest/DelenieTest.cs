using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class DelenieTest
    {
        [TestMethod]
        public void DelenieTest1()
        {
            BinaryOperation calc = fabric.Calc("/");
            double rez1 = calc.Calculate(18,3);
            Assert.AreEqual(6, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(-8,4);
            Assert.AreEqual(-2, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(144,12);
            Assert.AreEqual(12, rez3, 0.001, "Ошибка");
        }
    }
}
