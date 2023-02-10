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


    }
}
