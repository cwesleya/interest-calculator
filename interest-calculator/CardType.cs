using System;
namespace interest_calculator
{
    public abstract class CardType
    {
        protected double _balance;
        protected double _rate;
        protected string _cardType;

        protected double GetInterestRate(string name)
        {
            return (double)(int)Enum.Parse(typeof(TypeName), name) / 100;
        }
    }
}
