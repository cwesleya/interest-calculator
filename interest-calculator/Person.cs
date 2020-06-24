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
                _totalInterest = TotalInterest(Wallets);
            
            return _totalInterest;
        }

        private double? TotalInterest(IList<Wallet> wallets)
        {
            return wallets
                    .Aggregate(0.0, (walletSum, wallet) => walletSum + (double)wallet.TotalInterest());          
        }
    }
}
