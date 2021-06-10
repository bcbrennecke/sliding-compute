using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SlidingCompute.Tests
{
    [TestClass]
    public class MovingAverageTests
    {

        [DataTestMethod]
        [DataRow(3, new double[] {0, 0.5, 1, 2}, new double[] {0, 1, 2, 3})] //Given Example
        [DataRow(5, new double[] {0, 0.5, -0.3333333333333333, 0.5, -0.4, 0.6, -0.8, 1, -1.2, 1.4}, new double[] {0, 1, -2, 3, -4, 5, -6, 7, -8, 9})] //Given Example
        [DataRow(5, new double[] {0,1}, new double[] {0,2})] //Window larger than InputArray
        [DataRow(1, new double[] {0,2}, new double[] {0,2})] //Window size of 1 should return input array
        [DataRow(1, new double[] {}, new double[] {})] //Empty array should return empty array
        public void MovingAverageDataTests(int WindowSize, double[] Expected, double[] InputArrayVals)
        {
            var ma = new MovingAverage();
            var computed = ma.Compute(WindowSize, InputArrayVals);
            CollectionAssert.AreEqual(Expected, computed, $"Expected: {arrayStrHelper(Expected)}; Received {arrayStrHelper(computed)}");
        }

        private string arrayStrHelper(double[] arr)
        {
            return String.Join(", ", arr);
        }
    }
}
