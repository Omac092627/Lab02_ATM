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

            if (ViewBalance() == 1)
            {
                ViewBalance();
            }
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
                int amt = 10000, a, current;
                Console.WriteLine("1.View Balance");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                string result = Console.ReadLine();
                int answer = int.Parse(result);
            //View Current Balance//
                if (answer == 1)
                {
                    Console.Clear();
                    Console.WriteLine("The current balance in your account is " + amt + "\n");
                }
            //Withdraw Money//
                if (answer == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount to withdraw" + "\n");
                    {
                        a = int.Parse(Console.ReadLine());
                        if (amt >= a)
                        {
                            if (a % 100 == 0)
                            {
                                current = amt - a;
                                Console.Clear();
                                Console.WriteLine("The current balance is now" + current + "\n");
                            }
                            else
                                Console.Clear();
                                Console.WriteLine("Please enter the amount to withdraw in the multiples of 100" + "\n");
                        }
                        else
                            Console.Clear();
                            Console.WriteLine("Your account does not have sufficient balance" + "\n");
                    }
                }
            //Deposit Money//
                else if (answer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount to be deposit");
                    a = int.Parse(Console.ReadLine());
                    current = amt + a;
                    Console.WriteLine("The current balance in the account is " + current + "\n");
                }
            //I thank you for using the ATM, now leave.//
                else if (answer == 4)
                {
                    Console.WriteLine("THANK YOU, GOODBYE!");
                    break;
                }
            }

        }


    }



}


