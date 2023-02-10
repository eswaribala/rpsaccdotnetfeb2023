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
            Account[] Accounts = new CurrentAccount[5];

            for(int i = 0; i < Accounts.Length; i++)
            {
                //constructor
                Accounts[i] = new CurrentAccount(i, AccountType.SAVINGS, new Random().Next(5000, 10000), new DateTime(2023, 2, new Random().Next(1,25)));
                //setter
               // Accounts[i].OverDraftLimit = 1000000;
              
            }

            foreach(var Account in Accounts)
            {
                Console.WriteLine("Account No{0}, Type{1}, Balance{2}, DOC{3}",
                    Account.AccountId,Account.AccountType,Account.Balance,Account.DOC);
                Console.WriteLine("Generated OTP={0}", Account.GenerateOTP());
            }
        }
    }
}
