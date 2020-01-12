using System;

namespace StatsCalc_IO
{
    public interface IVariance { 
        public double variancev(double[] arrayvalues);
    }
    public class Variance : IVariance
{
        public double variancev(double[] arrayvalues)
        {
            double variancevalue = 0;// StatsOperations.Variance.variance(arrayvalues);//<---class name and method calculating variance type here
            return variancevalue;
        }
    }
}
