using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
   public class StandardDeviation
    {
        
        public static double SD(double[] ArrayValues)
        {
           double result = Squareroot.Sq(Variance.Findvariance(ArrayValues));

            return Helpers.Rounding.RoundTwoDecimalPlaces(result);
            
        }

    }
}
