using System;
using System.Collections.Generic;
using System.Linq;

namespace interest_calculator
{
    public class Wallet : ITotalInterestCalculator
    {
        private double? _totalInterest;

        public List<Card> Cards;

        public Wallet(List<Card> cards)
        {
            Cards = cards;
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)
            {
                _totalInterest = Cards
                    .Aggregate(0.0, (cardSum, card) => cardSum + (double)card.TotalInterest());
            }

            return _totalInterest;
        }
    }
}
