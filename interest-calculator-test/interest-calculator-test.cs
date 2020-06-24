using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using interest_calculator;
using System.Collections.Generic;

namespace interest_calculator_test
{
    [TestClass]
    public class InterestCalculatorUnitTests
    {
        [TestMethod]
        public void OnePerson_OneWallet_ThreeCards()
        {
            var discoverCard = new Card("Discover", 100.0);
            var masterCard = new Card("Mastercard", 100.0);
            var visaCard = new Card("Visa", 100.0);

            var cards = new List<Card>
            {
                discoverCard,
                masterCard,
                visaCard
            };

            var wallet = new Wallet(cards);

            var person = new Person(new List<Wallet> { wallet });

            //total interest for this person
            Assert.AreEqual(16.0, person.TotalInterest());

            //total interest per card
            Assert.AreEqual(1.0, discoverCard.TotalInterest());
            Assert.AreEqual(5.0, masterCard.TotalInterest());
            Assert.AreEqual(10.0, visaCard.TotalInterest());
        }

        [TestMethod]
        public void OnePerson_TwoWallets_ThreeCards()
        {
            var discoverCard = new Card("Discover", 100);
            var masterCard = new Card("Mastercard", 100);
            var visaCard = new Card("Visa", 100);

            var wallet1 = new Wallet(new List<Card> { discoverCard, visaCard });
            var wallet2 = new Wallet(new List<Card> { masterCard });

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
            var discoverCard = new Card("Discover", 100);
            var masterCard1 = new Card("Mastercard", 100);
            var visaCard1 = new Card("Visa", 100);

            var masterCard2 = new Card("Mastercard", 100);
            var visaCard2 = new Card("Visa", 100);

            var wallet1 = new Wallet(new List<Card> { discoverCard, masterCard1, visaCard1 });
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
