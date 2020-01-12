using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalc_IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsCalc_IO.Tests
{
    [TestClass()]
    public class ModeTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Mode mod = new Mode();

        [TestMethod()]
        public void modevTest()
        {
            Assert.AreEqual(01, mod.modev(ArrayList));
        }
    }
}