using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class SinTest
    {
        [TestMethod]
        public void SinTest1()
        {
            Operation calc = MonoFabric.Calc("sin");
            double rez1 = calc.Calculate(0.5);
            Assert.AreEqual(0.4794, rez1, 0.0001, "Ошибка");
            double rez2 = calc.Calculate(-2);
            Assert.AreEqual(-0.909, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(-0.967, rez3, 0.001, "Ошибка");
        }
    }
}
