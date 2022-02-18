using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnDStatBlockOdds;
using System;

namespace DebugTests
{
    [TestClass]
    public class ComparisonTests
    {
        [TestMethod]
        public void SimpleGreaterThanTrue()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 18);
            var y = new StatBlock(3, 3, 3, 3, 3, 3);
            Assert.IsTrue(x > y);
        }

        [TestMethod]
        public void SimpleGreaterThanFalse()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 18);
            var y = new StatBlock(3, 3, 3, 3, 3, 3);
            Assert.IsFalse(y > x);
        }

        [TestMethod]
        public void SimpleLessThanTrue()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 18);
            var y = new StatBlock(3, 3, 3, 3, 3, 3);
            Assert.IsTrue(y < x);
        }

        [TestMethod]
        public void SimpleLessThanFalse()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 18);
            var y = new StatBlock(3, 3, 3, 3, 3, 3);
            Assert.IsFalse(x < y);
        }

        [TestMethod]
        public void ComplicatedGreaterThanTrue()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 3);
            var y = new StatBlock(3, 3, 3, 3, 3, 18);
            Assert.IsTrue(x > y);
        }

        [TestMethod]
        public void ComplicatedLessThanTrue()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 3);
            var y = new StatBlock(3, 3, 3, 3, 3, 18);
            Assert.IsTrue(y < x);
        }

        [TestMethod]
        public void ComplicatedGreaterThanFalse()
        {
            var x = new StatBlock(10,10,10,10,10,10);
            var y = new StatBlock(3, 3, 3, 3, 3, 18);
            Assert.IsFalse(x > y);
        }

        [TestMethod]
        public void ComplicatedLessThanFalse()
        {
            var x = new StatBlock(10, 10, 10, 10, 10, 10);
            var y = new StatBlock(3, 3, 3, 3, 3, 18);
            Assert.IsFalse(y < x);
        }

        [TestMethod]
        public void EqualGreaterThanFalse()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 3);
            var y = new StatBlock(18, 18, 18, 18, 18, 3);
            Assert.IsFalse(x > y);
        }

        [TestMethod]
        public void EqualLessThanFalse()
        {
            var x = new StatBlock(18, 18, 18, 18, 18, 3);
            var y = new StatBlock(18, 18, 18, 18, 18, 3);
            Assert.IsFalse(y < x);
        }
    }
}
