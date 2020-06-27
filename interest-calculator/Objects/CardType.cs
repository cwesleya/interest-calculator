using System;

namespace interest_calculator
{
    public abstract class CardType
    {
        protected string _cardType;
        protected double? _rate;

        protected double InterestRate(string type)
        { 
            return (double)(int)Enum.Parse(typeof(TypeName), type) / 100;
        }

        protected bool TypeExists(string type)
        {
            return Enum.IsDefined(typeof(TypeName), type);
        }
    }
}
