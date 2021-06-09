using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SlidingCompute.Tests
{
    [TestClass]
    public class MovingAverageTests
    {
        [TestMethod]
        public void GivenExamplesTest()
        {
            var ma = new MovingAverage();
            var expected1 = new double[] {0, 0.5, 1, 2};
            var answer1 = ma.Compute(3, new double[] {0, 1, 2, 3});

            CollectionAssert.AreEqual(expected1, answer1, $"Expected: {arrayStrHelper(expected1)}; Received {arrayStrHelper(answer1)}");


            var expected2 = new double[] {0, 0.5, -0.3333333333333333, 0.5, -0.4, 0.6, -0.8, 1, -1.2, 1.4};
            var answer2 = ma.Compute(5, new double[] {0, 1, -2, 3, -4, 5, -6, 7, -8, 9});
            
            CollectionAssert.AreEqual(expected2, answer2, $"Expected: {arrayStrHelper(expected2)}; Received {arrayStrHelper(answer2)}");

            Assert.AreEqual(expected2[2], (double)-0.333333333333333333333333);


           

        }
        //Questions
        // I believe the answer to the second example, in slot 2 can have 16 digits of precision after the decimal in a Double, but the example only has 15.
        // Is it important to deal with this ambigutiy in the program, or would it be acceptable to round all numbers to 15 places (or less) for the sake of this exercise?
        //
        // What would be the appropriate response from the program if a given window size is larger than the given array?  E.g. compute(3, [1,2])
        // As the user, would you prefer it to calculate as normal (e.g. compute(3, [1,2]) => [1, 1.5]), or throw an error?

        private string arrayStrHelper(double[] arr)
        {
            return String.Join(", ", arr);
        }
    }
}
