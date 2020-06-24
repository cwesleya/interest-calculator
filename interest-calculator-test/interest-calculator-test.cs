using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using interest_calculator;
using System.Collections.Generic;

namespace interest_calculator_test
{
    [TestClass]
    public class InterestCalculatorUnitTests
    {
        private Card _discoverCard = new Card("Discover", 100.0);
        private Card _masterCard = new Card("Mastercard", 100.0);
        private Card _visaCard = new Card("Visa", 100.0);

        [TestMethod]

        public void OnePerson_OneWallet_ThreeCards()
        {
            var cards = new List<Card>
            {
                _discoverCard,
                _masterCard,
                _visaCard
            };

            var wallet = new Wallet(cards);

            var person = new Person(new List<Wallet> { wallet });

            //total interest for this person
            Assert.AreEqual(16.0, person.TotalInterest());

            //total interest per card
            Assert.AreEqual(1.0, _discoverCard.TotalInterest());
            Assert.AreEqual(5.0, _masterCard.TotalInterest());
            Assert.AreEqual(10.0, _visaCard.TotalInterest());
        }

        [TestMethod]
        public void OnePerson_TwoWallets_ThreeCards()
        {
            var wallet1 = new Wallet(new List<Card> { _discoverCard, _visaCard });
            var wallet2 = new Wallet(new List<Card> { _masterCard });

            var person = new Person(new List<Wallet> { wallet1, wallet2 });

            //total interest for this person
            Assert.AreEqual(16.0, person.TotalInterest());

            //total interest per wallet
            Assert.AreEqual(11.0, wallet1.TotalInterest());
            Assert.AreEqual(5.0, wallet2.TotalInterest());
        }

        [TestMethod]
        public void TwoPersons_TwoWallets_FiveCards()
        {
            var masterCard2 = new Card("Mastercard", 100);
            var visaCard2 = new Card("Visa", 100);

            var wallet1 = new Wallet(new List<Card> { _discoverCard, _masterCard, _visaCard });
            var wallet2 = new Wallet(new List<Card> { masterCard2, visaCard2 });

            var person1 = new Person(new List<Wallet> { wallet1 });
            var person2 = new Person(new List<Wallet> { wallet2 });

            //total interest per person
            Assert.AreEqual(16.0, person1.TotalInterest());
            Assert.AreEqual(15.0, person2.TotalInterest());

            //total interest per wallet
            Assert.AreEqual(16.0, wallet1.TotalInterest());
            Assert.AreEqual(15.0, wallet2.TotalInterest());
        }

    }
}
