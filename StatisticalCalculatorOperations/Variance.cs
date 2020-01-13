using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
    public class Variance
    {
        
        public static dynamic Findvariance(double[]arrayA)
        {
                
           double mean = Mean.MeanValue(arrayA);
            double[] squaredDeviation = new double[Helpers.Arraylength.ArrayLength(arrayA)];

            int i = 0;

            foreach (int a in squaredDeviation)
            {
                squaredDeviation[i] = Square.Sqr(Subtraction.Sub(a,mean));

                i++;
            }

             return  Mean.MeanValue(squaredDeviation);

            

        }

    }
}

