using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatsOperations
{
    public class Mode
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public static double mode(double[] ArrayValues)
        {

            var mode = ArrayValues.GroupBy(n => n).
                       OrderByDescending(g => g.Count()).
                       Select(g => g.Key).FirstOrDefault();
            return mode;
        }
    }
}
