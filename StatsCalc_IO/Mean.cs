using System;
using StatsOperations;

namespace StatsCalc_IO
{
    public interface IMean
    {
        public double meanv(double[] arrayvalues);
    }
    public class Mean : IMean
    {
        public double meanv(double[] arrayvalues)
        {
            double mv = 0;// StatsOperations.Mean.mean(arrayvalues);//<---class name and method calculating mean type here
            return mv;
        }
    }
}
