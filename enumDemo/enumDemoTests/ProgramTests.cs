using Microsoft.VisualStudio.TestTools.UnitTesting;
using enumDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void swapTest()
        {
            int bob = 55, sam = 66;
            Program.swap(ref bob, ref sam);
            Assert.AreEqual(bob, 66);
            Assert.AreEqual(sam, 55);
        }

        [TestMethod()]
        public void doNothingTest()
        {
            Assert.Fail();
        }
    }
}