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

        static public decimal ViewBalance()
        {
            int amount = 1000;
            Console.WriteLine(" YOUR BALANCE IS : {0} ", amount);


            return amount;
        }

        public static void Main(string[] args)
        {

            OprahsBankAccount();
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
                    int amt = 10000;

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
                        Console.WriteLine("The current balance in your account is " + amt.ToString("c") + "\n");
                    }
                    //Withdraw Money//
                    if (answer == 2)
                    {
                        Withdraw();
                    
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
        static public decimal Withdraw()
        {
            while (true)
            {
                try
                {
                    int amt = 10000, a;

                    //Withdraw Money//

                    Console.WriteLine("Enter the amount to withdraw " + "\n");

                    a = (int)Convert.ToDecimal(Console.ReadLine());

                    if (a % 1 != 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (a < 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 1");
                    }
                    else if (a > (amt - 500))
                    {
                        Console.WriteLine("\n INSUFFICENT BALANCE");
                    }
                    else
                    {
                        amt = amt - a;
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amt);

                        return amt;
                    }
                    break;
                }
                catch (FormatException e)

                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
                return 0;
        }

        static public decimal Deposit()
        {
            {
                while (true)
                {
                    try
                    {
                        int amt = 10000, a, current;
                        Console.WriteLine("Enter the amount to be deposit");
                        a = (int)Convert.ToDecimal(Console.ReadLine());

                        if (a <= 0)
                        {
                            Console.WriteLine("You cannot enter a negative amount, dummy!");
                        }
                        else
                        {
                            current = amt + a;
                            Console.WriteLine("The current balance in the account is " + current.ToString("c") + "\n");
                            CurrentBalance(current, amt);
                            return current;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                    return 0;
                }

                 static decimal CurrentBalance(int balance, int amt)
                {
                    balance += amt;
                    return 0;
                }


            }
        }

    }
}








