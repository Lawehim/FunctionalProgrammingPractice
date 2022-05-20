using System;

namespace Workings
{
    public class ComputeExample
    {
        public static decimal CalculateDiscount(decimal amount, decimal discountRate)
        {
            return amount * (1 - (1 - discountRate/100));

            
            
        }
    }
}
