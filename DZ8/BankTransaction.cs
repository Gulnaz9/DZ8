using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class BankTransaction
    {
        public readonly DateTime TransactionDate;
        public readonly decimal Amount;

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            TransactionDate = DateTime.Now;
        }
    }
}
