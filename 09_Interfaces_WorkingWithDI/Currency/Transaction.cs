using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public class Transaction
    {
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; }

        public decimal GetTransactionValue()
        {
            return _currency.Value;
        }

        // When called, return _currency.Name
        public string GetTransactionType() => _currency.Name;
    }
}
