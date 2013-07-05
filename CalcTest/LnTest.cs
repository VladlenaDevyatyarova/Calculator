using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class LnTest
    {
        [TestMethod]
        public void LnTest1()
        {
            Operation calc = MonoFabric.Calc("ln");
            double rez1 = calc.Calculate(1);
            Assert.AreEqual(0, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(-2);
            Assert.AreEqual(0, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(18.408, rez3, 0.001, "Ошибка");
        }
    }
}
