using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class CosTest
    {
        [TestMethod]
        public void CosTest1()
        {
            Operation calc = MonoFabric.Calc("cos");
            double rez1 = calc.Calculate(0.5);
            Assert.AreEqual(0.8775, rez1, 0.0001, "Ошибка");
            double rez2 = calc.Calculate(-2);
            Assert.AreEqual(-0.416, rez2, 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(-0.252, rez3, 0.001, "Ошибка");
        }
    }
}
