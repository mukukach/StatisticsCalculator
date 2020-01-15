using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helper;
using MathOperations;

namespace StatsOperations
{
    public class Median
    {
        public static double median(double[] ArrayValues)
        {
            double medianv = 0;
            int a = Division.Div(HelperClass.ArrayLenth(ArrayValues),2);

            if (a % 2 == 0)
            {
                //medianv = (ArrayValues[a-1] + (ArrayValues[a]))/2;
                medianv = (((double)ArrayValues.ElementAt(a) + (double)ArrayValues.ElementAt(a- 1)) / 2);

            }
            else if (a % 2 > 0)
            {

                // medianv = ArrayValues[a];
                medianv = (double)ArrayValues.ElementAt(a);

            }
            

            return medianv;

        }
    }
}
