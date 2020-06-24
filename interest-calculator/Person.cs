using System;
using System.Collections.Generic;
using System.Linq;

namespace interest_calculator
{
    public class Person : ITotalInterestCalculator
    {
        private double? _totalInterest;

        public List<Wallet> Wallets;

        public Person(List<Wallet> wallets)
        {
            Wallets = wallets;
        }

        public double? TotalInterest()
        {
            if (_totalInterest == null)
            {
                _totalInterest = Wallets
                    .Aggregate(0.0, (sum, wallet) => sum + (double)wallet.TotalInterest());
            }

            return _totalInterest;
        }
    }
}
