using System;
using System.Collections.Generic;
using interest_calculator.Utility;

namespace interest_calculator
{
    public class Person : ITotalInterestCalculator
    {
        private double? _totalInterest;

        public List<ITotalInterestCalculator> Wallets;

        public Person(List<ITotalInterestCalculator> wallets)
        {
            Wallets = wallets;
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)
                _totalInterest = CalculateInterest.Calculate(Wallets);

            return _totalInterest;
        }
    }
}
