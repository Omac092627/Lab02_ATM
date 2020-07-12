using System;
using Xunit;
using static Lab02_ATM.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        //View Balance//
        [Fact]
        public void WhatsMyBalance()
        {
            //Arrange 
            decimal amt = 100;
            Balance = amt;

            // Act
            decimal answer = ViewBalance();

            // Assert
            Assert.Equal(amt, answer);
        }

        [Fact]
        public void BalanceMore()
        {
            decimal amt = 100;
            Balance = amt;

            decimal answer = ViewBalance();

            Assert.Equal(amt, answer);
        }



        //Kyungrae helped me but for someone reason my computer isn't registering certain test//
        //if you find the issue, please let me know//

        //Withdraw methods//
        [Fact]
        public void AnotherBalance()
        {
            int amt = 100;
            Balance = amt;
            decimal withdrawl = 30;

            decimal expected = 70;
            decimal result = Withdraw(withdrawl);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void TakeMoneyOut()
        {
            //Arrange 
            decimal amt = 100;
            Balance = amt;
            decimal withdrawl = 30;

            // Act
            decimal expected = 30;
            decimal result = Withdraw(withdrawl);


            // Assert
            Assert.Equal(expected, result);
        }



        //Deposit methods//

        [Fact]
        public void PutMoneyIn()
        {
            //Arrange 
            int amt = 100;
            Balance = amt;
            decimal deposit = 200;

            // Act
            decimal expected = 300;
            decimal answer = Deposit();

            // Assert
            Assert.Equal(expected, answer);
        }



        [Fact]
        public void PutMoreMoneyIn()
        {
            int amt = 200;
            Balance = amt;
            decimal deposit = 300;



            decimal expected = 500;
            decimal answer = Deposit();

            Assert.Equal(expected, answer);
        }



    }
}
