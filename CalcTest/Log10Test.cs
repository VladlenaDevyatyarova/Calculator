using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class Log10Test
    {
        [TestMethod]
        public void Log10Test1()
        {
            Operation calc = MonoFabric.Calc("ln10");
            double rez1 = calc.Calculate(0.5);
            Assert.AreEqual(-0.301, rez1, 0.001, "Ошибка");
        }
    }
}
