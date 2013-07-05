using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class UmnogenieTest
    {
        [TestMethod]
        public void UmnogenieTest1()
        {
            BinaryOperation calc = fabric.Calc("*");
            double rez1 = calc.Calculate(2, 1);
            Assert.AreEqual(2, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(5.98, 10.43);
            Assert.AreEqual(62.371, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(8, 0);
            Assert.AreEqual(0, rez3, 0.001, "Ошибка");
            double rez4 = calc.Calculate(-8, -7);
            Assert.AreEqual(56, rez4, 0.001, "Ошибка");
            double rez5 = calc.Calculate(-11, 12);
            Assert.AreEqual(-132, rez5, 0.001, "Ошибка");
            double rez6 = calc.Calculate(568, 344);
            Assert.AreEqual(195392, rez6, 0.001, "Ошибка");
        }
    }
}
