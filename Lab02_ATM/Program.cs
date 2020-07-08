using System;

namespace Lab02_ATM
{
    public class Program
    {
        /// <summary>
        /// For the first part I want to establish my intiate sequence and start the atm program.
        /// </summary>
        /// <param name="args"></param>
        /// 


        static public decimal ViewBalance()
        {
            int amount = 1000;
            Console.WriteLine(" YOUR BALANCE IS : {0} ", amount);

            if(ViewBalance() == 1)
            {
                ViewBalance();
            }
            return amount;
        }

        public static void Main(string[] args)
        {
            OprahsBankAccount();
        }

        public static void OprahsBankAccount()
        {       

            if(true)
            {
                int amt = 10000, a, current;

                Console.WriteLine("1.View Balance");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                string result = Console.ReadLine();
                int answer = int.Parse(result);

                if (answer == 1)
                {
                    Console.WriteLine("The current balance in your account is " + amt);
                }

                if (answer == 2)
                {
                    Console.WriteLine("Enter the amount to withdraw");
                    {
                        a = int.Parse(Console.ReadLine());
                        if (amt >= a)
                        {
                            if (a % 100 == 0)
                            {
                                current = amt - a;
                                Console.WriteLine("The current balance is now" + current);
                            }
                            else
                                Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                        }
                        else
                            Console.WriteLine("Your account does not have sufficient balance");
                    }
                }

                else if (answer == 3)
                {
                    Console.WriteLine("Enter the amount to be deposit");
                    a = int.Parse(Console.ReadLine());
                    current = amt + a;
                    Console.WriteLine("The current balance in the account is" + current);
                }
                else if(answer == 4)
                {
                    Console.WriteLine("THANK YOU…");
                }
                }

            }


        }



    }


