﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest
{
    [TestClass]
    public class AsinTest
    {
        [TestMethod]
        public void AsinTest1()
        {
            Operation calc = MonoFabric.Calc("asin");
            Assert.AreEqual(0.5236, calc.Calculate(0.5), 0.0001, "Ошибка");
    
            Assert.AreEqual(-1.107, calc.Calculate(-2), 0.001, "Ошибка");
            double rez3 = calc.Calculate(98765432);
            Assert.AreEqual(1.57, rez3, 0.001, "Ошибка");
        }
    }
}
