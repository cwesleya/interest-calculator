using System;
using System.Collections.Generic;

namespace interest_calculator
{
    public interface ITotalInterestCalculator
    {
        private double? _totalInterest
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
        public double? TotalInterest();
    }
}
