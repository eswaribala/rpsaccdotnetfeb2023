// See https://aka.ms/new-console-template for more information
//Top level Statements

//Console.WriteLine("Hello, World!");
using System;
namespace CsharpFundamentals
{

    //This describes c# Entrypoint
    /*
     * I am a beginner
     * Training Started on 06/02/2023
     */
   /// <summary>
   /// This is Main
   /// </summary>
  ///<remarks>Kick Started</remarks>
    public enum AccountType { SAVINGS,CURRENT,DEMAT,LOAN}
    public class Fundamental
    {

        public static void Main()
        {
            Console.WriteLine("Ready to Learn c#");
            double ROI = 0.65;
            //Enter Account Type
            Console.WriteLine("Enter Account Type");
            string? value= Console.ReadLine();
            AccountType result,accountType;
            if(Enum.TryParse<AccountType>(value,out result))
            {
                accountType = result;
                Console.WriteLine("Account Type{0}", accountType);

            }

            string? path = @"G:\Local disk\dot35\Deepa
                                  \_netmaterialforreview\UptoException";
            Console.ReadKey();

        }
    }
}