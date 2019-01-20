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
    public class _134GasStationTests
    {
        [TestMethod()]
        public void CanCompleteCircuitShouldReturnMunis1()
        {
            var ccc = new _134GasStation();
            var gas = new int[] { 2,3,4};
            var cost = new int[] { 3, 4, 3 };
            var value = ccc.CanCompleteCircuit(gas, cost);

            Assert.AreEqual(-1, value);
        }

        [TestMethod()]
        public void CanCompleteShouldReturn3()
        {
            var ccc = new _134GasStation();
            var gas = new int[] { 1, 2, 3, 4, 5 };
            var cost = new int[] { 3, 4, 5, 1, 2 };
            var value = ccc.CanCompleteCircuit(gas, cost);

            Assert.AreEqual(3, value);
        }
    }
}