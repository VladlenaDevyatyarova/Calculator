using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class SqrtTest
    {
        [TestMethod]
        public void SqrtTest1()
        {
            Operation calc = MonoFabric.Calc("sqrt");
            double rez1 = calc.Calculate(9);
            Assert.AreEqual(3, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(-4);
            Assert.AreEqual(0, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(9938.079, rez3, 0.001, "Ошибка");
            double rez4 = calc.Calculate(0.0025);
            Assert.AreEqual(0.05, rez4, 0.001, "Ошибка");
        }
    }
}
