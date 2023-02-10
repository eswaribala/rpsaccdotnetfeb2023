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
            SavingsAccount[] Accounts = new SavingsAccount[5];

            for(int i = 0; i < Accounts.Length; i++)
            {
                //constructor
                Accounts[i] = new SavingsAccount(i, AccountType.SAVINGS, new Random().Next(5000, 10000), new DateTime(2023, 2, new Random().Next(25)));
                //setter
                Accounts[i].InterestRate = 0.865f;
              
            }

            foreach(var Account in Accounts)
            {
                Console.WriteLine("Account No{0}, Type{1}, Balance{2}, DOC{3},Interest Rate{4}",
                    Account.AccountId,Account.AccountType,Account.Balance,Account.DOC, Account.InterestRate);
                Console.WriteLine("Generated OTP={0}", Account.GenerateOTP());
            }
        }
    }
}
