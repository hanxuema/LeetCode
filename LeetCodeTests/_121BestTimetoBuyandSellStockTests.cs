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
    public class _121BestTimetoBuyandSellStockTests
    {
        [TestMethod()]
        public void MaxProfitTestShouldReturn6()
        {
            var mp = new _121BestTimetoBuyandSellStock();
            var result = mp.MaxProfit(new int[] { 7, 2, 5, 3, 4, 2,6, 1 });
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void MaxProfitTestShouldReturn0()
        {
            var mp = new _121BestTimetoBuyandSellStock();
            var result = mp.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, result);
        }
    }
}