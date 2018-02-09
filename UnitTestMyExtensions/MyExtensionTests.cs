using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensions;

namespace UnitTestMyExtensions
{
    [TestClass]
    public class MyExtensionTests
    {
        [TestClass()]
        public class MyExtensionMethodsTests
        {
            [TestMethod()]
            public void StdevTest()
            {
                int[] numbers = { 12, 55, 74, 79, 90 };
                Assert.AreEqual(27.4, Math.Round(numbers.Stdev(), 1));
            }

            [TestMethod()]
            public void RoundToTest()
            {
                var rounded5 = MyExtensions.MyExtensionMethods.RoundTo(9.91m, 5);
                Assert.AreEqual(9.90m , (decimal)rounded5);
                var rounded20 = MyExtensions.MyExtensionMethods.RoundTo(10.00m, 20);
                Assert.AreEqual(10m, (decimal)rounded20);
            }
        }
    }
}
