using System;

namespace StatsCalc_IO
{
    public interface IStandardDeviation
    {
        public double StandardDeviationv(double[] arrayvalues);
    }
    public class StandardDeviation : IStandardDeviation
    {
        public double StandardDeviationv(double[] arrayvalues)
        {

            double sdvalue = 0;// StatsOperations.StandardDev.StanDev(arrayvalues);  //<---//class name and method calculating standard deviation type here
            return sdvalue;  //<--return Standard Deviation values
        }
    }
}
