using System;
using Xunit;
using static Lab02_ATM.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance() 
        {
                //Arrange 
                int amt = 10000;

                // Act
                int value = amt;


                // Assert
                Assert.Equal(1, value);
            
        }
        [Fact]
        public void Withdraw()
        {
                //Arrange 
                int amt = 10000;

                // Act
                int value = 400 - amt;


                // Assert
                Assert.Equal(9600, value);
        }

        [Fact]
                public void Deposit()
                {
                    //Arrange 
                    int amt = 10000;

                    // Act
                    int value = 400 + amt;


                    // Assert
                    Assert.Equal(10400, value);
                }
    }
}
