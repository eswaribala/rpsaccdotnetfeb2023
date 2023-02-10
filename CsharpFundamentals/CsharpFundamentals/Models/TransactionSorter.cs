using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    internal class TransactionSorter : IComparer<Transaction>
    {
        public int Compare(Transaction? x, Transaction? y)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return x.TransactionAmount.CompareTo(y.TransactionAmount);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
