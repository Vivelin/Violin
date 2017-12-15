using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vivelin.Violin.Tests
{
    [TestClass]
    public class AlphanumericStringIncrementorTests
    {
        private static readonly AlphanumericStringIncrementor incrementor = new AlphanumericStringIncrementor();

        [TestMethod]
        public void Increment_0_Returns1()
        {
            Assert.AreEqual("1", "0".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_9_Returns00()
        {
            Assert.AreEqual("00", "9".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_CapitalA_ReturnsCapitalB()
        {
            Assert.AreEqual("B", "A".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_CapitalZ_ReturnsAA()
        {
            Assert.AreEqual("AA", "Z".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_FinalCharacter_ResetsAndCarries()
        {
            Assert.AreEqual("ba", "az".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_NonAlphanumericCharacter_ReturnsNextCodepoint()
        {
            Assert.AreEqual("💩", "💨".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_SmallA_ReturnsSmallB()
        {
            Assert.AreEqual("b", "a".Increment(incrementor));
        }

        [TestMethod]
        public void Increment_SmallZ_ReturnsAA()
        {
            Assert.AreEqual("aa", "z".Increment(incrementor));
        }
    }
}