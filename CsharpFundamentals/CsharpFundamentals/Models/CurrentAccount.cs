using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    public class CurrentAccount:Account
    {
        public CurrentAccount(long accountId, AccountType accountType, 
            long balance, DateTime dOC) : base(accountId, accountType, balance, dOC)
        {
        }

        public long OverDraftLimit { get; set; }

        public override string GenerateOTP()
        {
            return "C"+base.GenerateOTP();
        }
    }
}
