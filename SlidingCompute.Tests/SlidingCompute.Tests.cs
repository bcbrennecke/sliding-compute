using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SlidingCompute.Tests
{
    [TestClass]
    public class SlidingComputeTests
    {

        [TestMethod]
        public void WindowSizeGreaterThanZero()
        {
            var ma = new MovingAverage();
            
            Assert.ThrowsException<System.Exception>(() => ma.Compute(0, new double[] {}));
        }

    }
}
