using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class AtgTest
    {
        [TestMethod]
        public void AtgTest1()
        {
            Operation calc = MonoFabric.Calc("atg");
            double rez1 = calc.Calculate(1);
            Assert.AreEqual(0.785, rez1, 0.001, "Ошибка");
            double rez2 = calc.Calculate(-2);
            Assert.AreEqual(-1.107, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(1.57, rez3, 0.001, "Ошибка");
        }
    }
}
