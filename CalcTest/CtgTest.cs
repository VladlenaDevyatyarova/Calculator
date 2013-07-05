using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class CtgTest
    {
        [TestMethod]
        public void CtgTest1()
        {
            Operation calc = MonoFabric.Calc("ctg");
            double rez1 = calc.Calculate(0.5);
            Assert.AreEqual(1.830, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(-2);
            Assert.AreEqual(0.457, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(0.260, rez3, 0.001, "Ошибка");
        }
    }
}
