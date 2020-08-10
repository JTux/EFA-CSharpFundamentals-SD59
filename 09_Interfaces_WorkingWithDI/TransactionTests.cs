﻿using System;
using _09_Interfaces_WorkingWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        // Dependency Injection with Methods
        private void PayDebt(ICurrency payment)
        {
            //_debt = _debt - payment.Value;
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt. You have ${_debt} left to pay.");
        }

        [TestMethod]
        public void PayDebtTest()
        {
            _debt = 9000.01m;

            var dollar = new Dollar();
            PayDebt(dollar);
            PayDebt(new Dime());
            PayDebt(new Penny());
            PayDebt(new ElectronicPayment(315.72m));

            // Starting Debt - whatever I paid above
            var expectedDebt = 9000.01m - 316.83m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            // Test data ICurrency objects
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(234.15m);

            // New Up Transactions with Test Data
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            // Calling Methods
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            // Asserts
            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(234.15m, secondTransaction.GetTransactionValue());
        }
    }
}
