using System;
using System.Collections.Generic;
using System.Linq;

namespace interest_calculator
{
    public interface ITotalInterestCalculator
    {
        double? _totalInterest
        {
            get
            {
                return _totalInterest;
            }
            set
            {
                _totalInterest = value;
            }
        }

        double? TotalInterest();
    }
}
