using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalc_IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsCalc_IO.Tests
{
    [TestClass()]
    public class VarianceTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Variance rv = new Variance();

        [TestMethod()]
        public void variancevTest()
        {
            Assert.AreEqual(8.5, rv.variancev(ArrayList));
        }
    }
}