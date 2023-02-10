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
            //List of accounts
            IList<Account> Accounts = new List<Account>();

            for(int i = 0; i < 100; i++)
            {
                //constructor
              Accounts.Add (new CurrentAccount(i, AccountType.SAVINGS, 
                  new Random().Next(5000, 10000), 
                  new DateTime(2023, 2, new Random().Next(1,25))));
                //setter
               // Accounts[i].OverDraftLimit = 1000000;
              
            }

            Accounts.Add(new CurrentAccount(100, AccountType.SAVINGS,
                  new Random().Next(5000, 10000),
                  new DateTime(2023, 2, new Random().Next(1, 25))));
            foreach (var Account in Accounts)
            {
                Console.WriteLine("Account No{0}, Type{1}, Balance{2}, DOC{3}",
                    Account.AccountId,Account.AccountType,Account.Balance,Account.DOC);
                Console.WriteLine("Generated OTP={0}", Account.GenerateOTP());
            }

            IDictionary<long, Transaction> Transactions = new Dictionary<long, Transaction>();

            for (int i = 0; i < 100; i++)
            {
                Transactions.Add(i, new Transaction()
                {
                    TransactionId = new Random().Next(1, 10000000),
                    TransactionAmount = new Random().Next(500, 5000000),
                    DOT = new DateTime(2023, 2, new Random().Next(1, 25)),
                    Account = new CurrentAccount(100, AccountType.SAVINGS,
                  new Random().Next(5000, 10000),
                  new DateTime(2023, 2, new Random().Next(1, 25)))
                });

            }

            //Retrieve Transactions
            foreach(KeyValuePair<long,Transaction> transaction in Transactions){

                Console.WriteLine("Key{0},Transaction Id{1}, Amount{2}",
                   transaction.Key, transaction.Value.TransactionId, transaction.Value.TransactionAmount);
            }


        }
    }
}
