using System;
using System.Collections.Generic;
using System.Linq;

namespace interest_calculator.Utility
{
    public static class CalculateInterest
    {
        public static double? Calculate(IList<ITotalInterestCalculator> items)
        {
            return items
                    .Aggregate(0.0, (sum, item) => sum + (double)item.TotalInterest());
        }

        public static double Calculate(double rate, double balance)
        {
            return rate * balance;
        }
    }
}
