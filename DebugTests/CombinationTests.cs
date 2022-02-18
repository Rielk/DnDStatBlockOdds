using DnDStatBlockOdds;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugTests
{
    [TestClass]
    public class CombinationTests
    {
        [TestMethod]
        public void Combination2d6()
        {
            var d6 = new Dice(1, 2, 3, 4, 5, 6);
            var combiner = new DiceCombiner(d6, d6);
            var res = combiner.Combinations();
            Assert.AreEqual(36, res.Count);
        }
    }
}
