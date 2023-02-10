using CsharpFundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    public class AccountApp
    {
        public static void Main()
        {
            //Array of accounts
            Account[] Accounts = new Account[5];

            for(int i = 0; i < Accounts.Length; i++)
            {
                Accounts[i] = new Account()
                {
                    AccountId = i,
                    AccountType = AccountType.SAVINGS,
                    Balance = new Random().Next(5000,10000),
                    DOC = new DateTime(2023, 2, new Random().Next(25))                    
                };
              
            }

            foreach(var Account in Accounts)
            {
                Console.WriteLine("Account No{0}, Type{1}, Balance{2}, DOC{3}",
                    Account.AccountId,Account.AccountType,Account.Balance,Account.DOC);
            }
        }
    }
}
