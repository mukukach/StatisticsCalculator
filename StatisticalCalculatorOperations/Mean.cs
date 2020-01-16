using System;
using Helpers;
using Operations;


namespace StatisticalCalculatorOperations
{
    public class Mean

    {
        
        public static dynamic MeanValue(double [] ArrayValues)
        {
            double Sum = Addition.Sum(ArrayValues);
            double Nitems = Helpers.Arraylength.ArrayLength(ArrayValues);
            
            return  Division.Divide(Sum, Nitems);

            
            
        }
    }
}
