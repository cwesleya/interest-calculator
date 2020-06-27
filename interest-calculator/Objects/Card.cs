using System;
using interest_calculator.Utility;

namespace interest_calculator
{
    public class Card : CardType, ITotalInterestCalculator
    {
        private double _balance;
        private double? _totalInterest;

        public Card(string type, double balance)
        {
            _cardType = type;
            _balance = balance;
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)           
                _totalInterest = CalculateInterest.Calculate(InterestRate(), _balance);
            
            return _totalInterest;
        }

        public double Balance() => _balance;

        public double InterestRate()
        {
            if (!TypeExists(_cardType))
                return 0.0;

            if (_rate == null)
                _rate = InterestRate(_cardType);

            return (double)_rate;
        }

        public string CardType() => _cardType;
    }
}
