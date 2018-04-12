using System;
using NUnit.Framework;
using static Day13_14Tasks1_4.BinarySearch;

namespace Day13_14Tasks1_4.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearchGenericTest_AcceptsEmptyArray_ThrowsException()
        {
            char[] charArray = new char[0];
            Assert.Throws<ArgumentNullException>(() => BinarySearchGeneric(charArray, 'A'));
        }

        [TestCase(new double[] { -1.234, 0, double.MaxValue, double.PositiveInfinity }, double.MinValue)]
        [TestCase(new string[] { "A", "C", "D", "F", "x" }, "Z")]
        public void BinarySearchGenericTest_AcceptsItemOutOfMaxOrMin_ThrowsException<T>(T[] array, T key) where T : IComparable => Assert.Throws<ArgumentException>(() => BinarySearchGeneric(array, key));

        [TestCase(new char[] { 'a', 'n', 'v', 'x', 'z' }, 'v', ExpectedResult = 2)]
        [TestCase(new int[] { int.MinValue, -100, 0, 44, 45, 100, 200 }, 45, ExpectedResult = 4)]
        [TestCase(new string[] { "A", "C", "D", "F", "x", "Y", "Z" }, "Z", ExpectedResult = 6)]
        public int BinarySearchGenericTest<T>(T[] array, T key) where T : IComparable
        {
            return BinarySearchGeneric(array, key);
        }
    }
}
