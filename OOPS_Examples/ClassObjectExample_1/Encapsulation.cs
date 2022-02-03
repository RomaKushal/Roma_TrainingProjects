using System;

namespace ClassObjectExample_1
{
    // Encapsulation : data hiding
    // can achieve by two ways :
    // 1. Declare variables of a class as Private
    // 2. Provide getter and setter method to modify and view variable values
    public class Encapsulation
    {
        static void main()
        {
            Account account = new Account();

            // if user assigns value from here directly he/she can assign any values like (negative etc.)
            //account.accountBalance = 10000;

            account.SetAccountBalance(10000);
            account.SetBalance = -100;
        }
    }
    public class Account
    {
        // Private variable
        int accountBalance = 1000;

        // use set method because in this method user can set validations 
        public void SetAccountBalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You cannot pass negative values.");
            }
            else
            {
                accountBalance = amount;
            }

        }

        // Alternate way to assign / set values
        public int SetBalance
        {
            // we can use settwe method to assign value this way
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("You cannot pass negative values.");
                }
                else
                {
                    accountBalance = value;
                }
            }
        }
    }
}