// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method AtoPowerB
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_APowerB;

namespace test_PowerFuntion
{
    [TestClass]
    public class test_PowerFunction
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int xValue = 2;
            int nValue = 4;

            //Act
            int calcValue = PowerClass.AtoPowerB(xValue, nValue);

            //Assert
            Assert.AreEqual(calcValue,16);
        }
    }
}
