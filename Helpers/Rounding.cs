using System;

namespace Helpers
{
    public class Rounding



    {


       public static dynamic RoundTwoDecimalPlaces(dynamic value)



        {



            return Math.Round(value, 2, MidpointRounding.ToEven);



        }



    }
}
