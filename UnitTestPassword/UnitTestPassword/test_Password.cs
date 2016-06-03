// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method PasswordCheck
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_Password;

namespace test_Password
{
    [TestClass]
    public class test_Password
    {
        [TestMethod]
        public void Password()
        {
            //Arrange
            string userEntry = "Betha+Andy12";

            //Act
            bool result = Password.PasswordCheck(userEntry);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
