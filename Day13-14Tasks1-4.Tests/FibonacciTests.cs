using System;
using System.Numerics;
using NUnit.Framework;
using static Day13_14Tasks1_4.Fibonacci;

namespace Day13_14Tasks1_4.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(-100)]
        [TestCase(0)]
        public void FibonacciGeneratorTest_AcceptsZeroOrNegativeLimit_ThrowsException(int amount) => Assert.Throws<ArgumentException>(() => FibonacciGenerator(amount));
                    
        [Test]
        public void FibonacciGeneratorTest1()
        {
            var b = new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            CollectionAssert.AreEqual(b, FibonacciGenerator(15));
        }

        [Test]
        public void FibonacciGeneratorTest2()
        {
            var b = new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 };
            CollectionAssert.AreEqual(b, FibonacciGenerator(22));
        }
    }
}
