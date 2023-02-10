using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    public class SavingsAccount:Account
    {
        public SavingsAccount(long accountId, AccountType accountType, long balance, DateTime dOC) : base(accountId, accountType, balance, dOC)
        {
        }

        public float InterestRate { get; set; }

       
    }
}
