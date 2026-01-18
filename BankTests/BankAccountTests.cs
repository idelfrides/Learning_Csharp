/* 
 ::::::::::::::  Project Overview :::::::::::::

  This project is one that contains unit tests for a simple bank account class using MSTest framework.


::::::::::::  Create and run unit tests for .NET :::::::::::::
 
 In this project I will use MSTest to create and run unit tests for a simple bank account class.
 
 The tests will cover various scenarios, including valid and invalid transactions.

  
::::::::::::  Test class requirements ::::::::::::

The minimum requirements for a test class are:

-> The [TestClass] attribute is required on any class that contains unit test methods that you want to run in Test Explorer.

-> Each test method that you want Test Explorer to recognize must have the [TestMethod] attribute.


:::::::::::: Test method requirements ::::::::::::

A test method must meet the following requirements:

-> It's decorated with the [TestMethod] attribute.

-> It returns void.

-> It cannot have parameters.

 */


using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;


namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void DebitWithValidAmountUpdatesBalance()
        {
            // Arrange
            double beginningBalance = 10000;
            double debitAmount = 1000;
            double expectedBalance = beginningBalance - debitAmount;
            var account = new BankAccount("Test User", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actualBalance = account.Balance;
            //Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedBalance, actualBalance, "Account not debited correctly");
        }

        [TestMethod]
        public void DebitWithAmountGreaterThanBalanceThrowsInvalidOperation()
        {
            // Arrange
            double beginningBalance = 10000;
            double debitAmount = 15000;       // greater than balance
            var account = new BankAccount("User Benvinda", beginningBalance);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void DebitWithAmountLessThanZeroThrowsArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 10000;
            double debitAmount = -1000;       // less than zero
            var account = new BankAccount("User Carlos", beginningBalance);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void DebitWithAmountEqualZeroThrowsArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 10000;
            double debitAmount = 0;         // equal zero
            var account = new BankAccount("User Pedro", beginningBalance);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}