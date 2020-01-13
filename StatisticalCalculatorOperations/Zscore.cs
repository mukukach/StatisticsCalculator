using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
   public class Zscore
    {
        public static double ZScore(dynamic score, dynamic values)

        {

            double mean = Mean.MeanValue(values);

            double standDev = StandardDeviation.SD(values);

            double zScore = Division.Divide(Subtraction.Sub(score, mean), standDev);

            return zScore;

        }
    }
}
