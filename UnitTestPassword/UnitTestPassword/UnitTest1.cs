// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method PasswordCheck
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Password;

namespace UnitTestPassword
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string userEntry = "Betha+Andy12";

            //Act
            bool result = Class1.PasswordCheck(userEntry);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
