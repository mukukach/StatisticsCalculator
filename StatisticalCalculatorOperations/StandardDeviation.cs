using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations
{
    public class StandardDev
    {

        public static double StanDev(double[] ArrayValues)
        {

            double VarValue = Variance.variance(ArrayValues);
            double sdeviation = Math.Sqrt(VarValue);
               
            return sdeviation;

        }
    }
}
