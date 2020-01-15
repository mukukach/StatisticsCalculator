using System;
using System.Collections.Generic;
using System.Text;
using Helper;
using MathOperations;

namespace StatsOperations
{
    public class Variance
    {
     
        public static double variance(double[] ArrayValues)
        {

            double  meanvalue=Mean.mean(ArrayValues);
           

            double diff = 0;
            int varvalue = 0;

            foreach (int i in ArrayValues)
            {
                diff = Subtraction.Sub((int) meanvalue,i);
                diff = Math.Pow(diff,2);
                varvalue = Addition.Add(varvalue ,(int) diff);
            }


            int ValueCount = HelperClass.ArrayLenth(ArrayValues);
            varvalue = Division.Div(varvalue,ValueCount);
            return varvalue;

        }

    }
}
