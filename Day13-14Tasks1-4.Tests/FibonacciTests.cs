using System;
using NUnit.Framework;
using static Day13_14Tasks1_4.Fibonacci;

namespace Day13_14Tasks1_4.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(-100)]
        [TestCase(0)]
        public void FibonacciGeneratorTest_AcceptsZeroOrNegativeLimit_ThrowsException(long limit) => Assert.Throws<ArgumentException>(() => FibonacciGenerator(limit));

        [TestCase(377, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 })]
        [TestCase(11000, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 })]        
        public void FibonacciGeneratorTest(long limit, long[] array)
        {
            CollectionAssert.AreEqual(array, FibonacciGenerator(limit).ToArray());
        }
    }
}
