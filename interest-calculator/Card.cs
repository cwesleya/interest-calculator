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
            return _totalInterest == null ? _rate * _balance : _totalInterest;
        }

        public double Balance() => _balance;

        public double InterestRate() => _rate;

        public string CardType() => _cardType;
    }
}
