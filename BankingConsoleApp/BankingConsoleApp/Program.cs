// See https://aka.ms/new-console-template for more information
using BankingConsoleApp.Models;

namespace Banking
{
    class App
    {
        public static void Main()
        {
            Console.WriteLine("Rocking with c#");
            //create customer object
            Customer customer = new Customer();
            customer.CustomerId = 428584;
            customer.Name = "Parameswari";
            customer.DOB = new DateTime(1970,12,2);
            Console.WriteLine("CustomerId={0},Customer Name={1},DOB={2}",
                customer.CustomerId,customer.Name,customer.DOB);
            Console.ReadKey();
        }
    }
}
