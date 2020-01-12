using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalc_IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsCalc_IO.Tests
{
    [TestClass()]
    public class MedianTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Median mdn= new Median();

        [TestMethod()]
        public void medianvTest()
        {
            Assert.AreEqual(6, mdn.medianv(ArrayList));
        }
    }
}