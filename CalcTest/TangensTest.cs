using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class TangensTest
    {
        [TestMethod]
        public void TangensTest1()
        {
            Operation calc = MonoFabric.Calc("tg");
            double rez1 = calc.Calculate(9);
            Assert.AreEqual(0, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(180);
            Assert.AreEqual(0, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(30);
            Assert.AreEqual(1, rez3, 0.001, "Ошибка");
            double rez4 = calc.Calculate(0);
            Assert.AreEqual(0, rez4, 0.001, "Ошибка");
            double rez5 = calc.Calculate(45);
            Assert.AreEqual(1, rez5, 0.001, "Ошибка");
        }
    }
}
