using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculatorOperations.Tests
{
    [TestClass()]
    public class ModeTests
    {
        private readonly int[] x = { 1, 5, 3, 1, 8, 1, 1, 4 };
        [TestMethod()]
        public void FindmodeTest()
        {
            Assert.AreEqual(1, Mode.Findmode(x));
        }
    }
}