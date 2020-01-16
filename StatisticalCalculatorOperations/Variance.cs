using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
    public class Variance
    {

        
        public static double Findvariance(double[] ArrayValues)
        {

            double meanvalue = Mean.MeanValue(ArrayValues);


            double diff = 0;
            double varvalue = 0;

            foreach (int i in ArrayValues)
            {
                diff = Subtraction.Sub((int)meanvalue, i);
                diff = Math.Pow(diff, 2);
                varvalue = Addition.Sum(varvalue, (int)diff);
            }


            int ValueCount = Helpers.Arraylength.ArrayLength(ArrayValues);
            varvalue = Division.Divide(varvalue, ValueCount);
            return varvalue;

        }

    }
}

