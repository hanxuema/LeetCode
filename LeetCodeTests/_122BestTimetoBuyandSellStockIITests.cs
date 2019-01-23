using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class _122BestTimetoBuyandSellStockIITests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            var mp = new _122BestTimetoBuyandSellStockII();
            var value = mp.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(7, value);
        }
    }
}