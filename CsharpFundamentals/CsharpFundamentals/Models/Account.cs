using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    public abstract class Account
    {
        public long AccountId { get; set; }
        public AccountType AccountType { get; set; }

        public long Balance { get; set; }   
        public DateTime DOC { get; set; }

        protected Account(long accountId, AccountType accountType, long balance, DateTime dOC)
        {
            AccountId = accountId;
            AccountType = accountType;
            Balance = balance;
            DOC = dOC;
        }

        public long GenerateOTP()
        {
            return new Random().Next(1000, 9999);
        }
    }
}
