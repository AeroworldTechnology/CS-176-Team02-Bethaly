using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumOfIntegersTest()
        {
            //Arrange
            int[] inputArray = { 5, 4, 1, 0 };

            //Act
            int resultSum = Program.SumOfIntegers(inputArray);

            //Assert
            Assert.AreEqual(resultSum, 10);
        }

        [TestMethod()]
        public void AContainsBTest()
        {
            //Arrage
            string sA = "Andy is a genius";
            string sB = "genius";

            //Act
            bool searchResult = Program.AContainsB(sA, sB);

            //Assert
            Assert.IsTrue(searchResult);
        }

        [TestMethod()]
        public void SwapAandBTest()
        {
            //Arrage
            int firstValue = 125;
            int secondValue = 37;

            //Act
            int[] swapResult = Program.SwapAandB(firstValue, secondValue);

            //Assert
            Assert.AreEqual(swapResult[0], 37);
            Assert.AreEqual(swapResult[1], 125);
        }

        [TestMethod()]
        public void AtoPowerBTest()
        {
            //Arrange
            int xValue = 2;
            int nValue = 4;

            //Act
            int calcValue = Program.AtoPowerB(xValue, nValue);

            //Assert
            Assert.AreEqual(calcValue, 16);
        }

        [TestMethod()]
        public void PasswordCheckTest()
        {
            //Arrange
            string userEntry = "Betha+Andy12";

            //Act
            bool result = Program.PasswordCheck(userEntry);

            //Assert
            Assert.IsTrue(result);
        }
    }
}