using System;
using System.Collections.Generic;
using System.Text;
using Helper;
using MathOperations;

namespace StatsOperations
{
    public class Mean
    {

        public static double mean(double[] ArrayValues)
        {


            double Sum = Addition.Add((int)Convert.ToDouble(ArrayValues));

            int ValueCount = HelperClass.ArrayLenth(ArrayValues);

            double Value =Division.Div(Sum,ValueCount);
            return Value;

        }

    }
}
