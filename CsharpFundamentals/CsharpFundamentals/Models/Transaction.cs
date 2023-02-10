using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    public enum TransactionType { ATM,DEBITCARD,CREDITCARD,WALLET}
    public  class Transaction
    {
        public long TransactionId { get; set; } 
        public long TransactionAmount { get; set; }
        public TransactionType TransactionType { get; set; }

        public DateTime DOT { get; set; }   

        //association

        public Account Account { get; set; }

    }
}
