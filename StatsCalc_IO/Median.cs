using System;

namespace StatsCalc_IO
{
    public interface IMedian
    {
        public double medianv(double[] arrayvalues);
    }
    public class Median : IMedian
    {
        public double medianv(double[] arrayvalues)
        {
            double mdv = 0;// StatsOperations.Median.median(arrayvalues); //<---class name and method calculating median 
            return mdv;
        }
    }
}
