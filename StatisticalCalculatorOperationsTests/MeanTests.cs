using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculatorOperations.Tests
{
    [TestClass()]
    public class MeanTests
    {
        private readonly double[] ArrayValues = { 1, 2, 3, 4 };
        [TestMethod()]
        public void MeanValueTest()
        {
            Assert.AreEqual(2.5, Mean.MeanValue(ArrayValues));
        }
    }
}