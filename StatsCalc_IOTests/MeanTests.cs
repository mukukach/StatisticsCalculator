using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalc_IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace StatsCalc_IO.Tests
{
    [TestClass()]
    public class MeanTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Mean mv = new Mean();

        [TestMethod()]
        public void meanvTest()
        {
            Assert.AreEqual(5,mv.meanv(ArrayList));
        }
    }
}