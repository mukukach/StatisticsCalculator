using System;

namespace StatsCalc_IO
{
    public interface IMode
    {
        public double modev(double[] arrayvalues);
    }
    public class Mode : IMode
    {
        public double modev(double[] arrayvalues)
        {
            double modv = 0;// StatsOperations.Mode.mode(arrayvalues); //<--- class name and method calculating mode 
            return modv;
        }
    }
}
