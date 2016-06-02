// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test SwapAandB
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSwapAB;

namespace SwapIntAB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            int firstValue = 125;
            int secondValue = 37;

            //Act

            int swapResult =SwapClass.SwapAandB(firstValue, secondValue);

            //Assert
            Assert.AreEqual(swapResult, 37);
        }
    }
}
