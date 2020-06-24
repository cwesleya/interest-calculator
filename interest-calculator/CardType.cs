using System;
namespace interest_calculator
{
    public abstract class CardType
    {
        protected double _balance;
        protected double _rate;
        protected double? _totalInterest;
        protected string _cardType;

        public double GetInterestRate(string type)
        {
            switch (type)
            {
                case "Discover":
                    return .01;
                case "Mastercard":
                    return .05;
                case "Visa":
                    return .10;
                default:
                    return 0;
            }
        }
    }
}
