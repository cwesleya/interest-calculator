using System;

namespace interest_calculator
{
    public class Card : CardType, ITotalInterestCalculator
    {
        public Card(string type, double balance)
        {
            _cardType = type;
            _balance = balance;
            _rate = GetInterestRate(type);            
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)
                _totalInterest = _rate * _balance;

            return _totalInterest;
        }

        public double Balance() => _balance;

        public double InterestRate() => _rate;

        public string CardType() => _cardType;
    }
}
