using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StatisticalCalculatorOperations
{
  public class Mode
    {
  
         public static double Findmode(double[] x)
        {
            double high = x.OrderByDescending(n => n).First();
            double mode = x.GroupBy(i => i)  //Grouping same items
            .OrderByDescending(g => g.Count()) //now getting frequency of a value
            .Select(g => g.Key) //selecting key of the group
            .FirstOrDefault();   //Finally, taking the most frequent value
           
            return mode;
        }



    }
}
