using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalc_IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsCalc_IO.Tests
{
    [TestClass()]
    public class StandardDeviationTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        StandardDeviation sd = new StandardDeviation();

        [TestMethod()]
        public void StandardDeviationvTest()
        {
            Assert.AreEqual(2.9154759474226504, sd.StandardDeviationv(ArrayList));
        }
    }
}