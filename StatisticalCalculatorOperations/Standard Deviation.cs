using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
    class Standard_Deviation
    {
        public static double SD(double result)
        {
            result = Variance.Findvariance;

            return  Squareroot.Sq(result);
            
        }

    }
}
