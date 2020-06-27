using System;
using System.Collections.Generic;
using System.Linq;
using interest_calculator.Utility;

namespace interest_calculator
{
    public class Wallet : ITotalInterestCalculator
    {
        private double? _totalInterest;

        public List<ITotalInterestCalculator> Cards;

        public Wallet(List<ITotalInterestCalculator> cards)
        {
            Cards = cards;
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)            
                _totalInterest = CalculateInterest.Calculate(Cards);                                

            return _totalInterest;
        }
    }
}
