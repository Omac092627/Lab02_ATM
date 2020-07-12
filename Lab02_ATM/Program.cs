using System;

namespace Lab02_ATM
{
    public class Program
    {
        /// <summary>
        /// For the first part I want to establish my intiate sequence and start the atm program.
        /// I do that by first putting my ViewBalance above all as to be able to access it from anywhere.
        /// OprahsBankAccount is my initiation sequence
        /// </summary>

        public static decimal Balance = 10000;
        public static void Main(string[] args)
        {

            OprahsBankAccount();
        }


        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your current balance is ${Balance}");
            return Balance;
        }


        /// <summary>
        /// OprahsBankAccount holds the main methods needed for the ATM:
        /// While Loop: Maintains the UI and doesn't close unless the user wants it to.
        /// if/else statements: shows balance, calculates money withdrew, calculates money deposited, and allows you to quit.
        /// </summary>

        public static void OprahsBankAccount()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("1.View Balance");
                    Console.WriteLine("2.Withdraw");
                    Console.WriteLine("3.Deposit");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                    string result = Console.ReadLine();
                    int answer = (int)Convert.ToDecimal(result);
                    //View Current Balance//
                    if (answer == 1)
                    {
                        Console.WriteLine("The current balance in your account is " + Balance.ToString("c") + "\n");
                    }
                    //Withdraw Money//
                    if (answer == 2)
                    {
                        Withdraw(answer);

                    }
                    //Deposit Money//
                    else if (answer == 3)
                    {
                        Deposit();
                    }
                    //I thank you for using the ATM, now leave.//
                    else if (answer == 4)
                    {
                        Console.WriteLine("THANK YOU, GOODBYE!");
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        /// <summary>
        /// Withdraw method takes the given amount and uses if/else statements to not only calculate the users withdraw amount, but also, allows the user to take out money less than 10 dollars.
        /// </summary>
        /// <returns></returns>
        public static decimal Withdraw(decimal withdrawl)
        {
            while (true)
            {
                try
                {

                    //Withdraw Money//

                    Console.WriteLine("Enter the amount to withdraw " + "\n");

                    withdrawl = (int)Convert.ToDecimal(Console.ReadLine());

                    if (withdrawl % 1 != 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (withdrawl == 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (withdrawl < 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (withdrawl > (Balance - 500))
                    {
                        Console.WriteLine("\n INSUFFICENT BALANCE");
                    }
                    else
                    {
                        Balance = Balance - withdrawl;
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", Balance);

                        return Balance;
                    }
                    return Balance;
                }
                catch (FormatException e)

                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// The deposit method allows you to deposit money in order to raise your bank account.
        /// I used a try catch to attempt to deposit the amount, if not, catch the exception.
        /// The deposit method doesn't allow you to deposit a negative number.
        /// </summary>
        /// <returns></returns>
        public static decimal Deposit()
        {
            {
                while (true)
                {
                    try
                    {
                        decimal a;
                        Console.WriteLine("Enter the amount to be deposit");
                        a = (int)Convert.ToDecimal(Console.ReadLine());

                        if (a <= 0)
                        {
                            Console.WriteLine("You cannot enter a negative amount, dummy!");
                        }
                        else
                        {
                            Balance = Balance + a;
                            Console.WriteLine("The current balance in the account is " + Balance.ToString("c") + "\n");
                            return Balance;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                    return Balance;
                }



            }
        }

    }
}








