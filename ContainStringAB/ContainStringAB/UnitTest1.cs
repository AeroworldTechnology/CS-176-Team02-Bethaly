using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestContains;

namespace ContainStringAB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            string sA = "Andy is a genius";
            string sB = "genius";

            //Act
            bool searchResult = Class1.AContainsB(sA, sB);

            //Assert
            Assert.IsTrue(searchResult);
        }
    }
}
