using System;
using interest_calculator.Utility;

namespace interest_calculator
{
    public class Card : CardType, ITotalInterestCalculator
    {
        private double? _totalInterest;

        public Card(string type, double balance)
        {
            _cardType = type;
            _balance = balance;
            _rate = Enum.IsDefined(typeof(TypeName), type) ?
                GetInterestRate(type) : 0.0;            
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)
                _totalInterest = CalculateInterest.Calculate(_rate, _balance);

            return _totalInterest;
        }

        public double Balance() => _balance;

        public double InterestRate() => _rate;

        public string CardType() => _cardType;
    }
}
