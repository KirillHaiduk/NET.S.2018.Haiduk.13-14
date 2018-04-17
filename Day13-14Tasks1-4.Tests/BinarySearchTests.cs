using System;
using NUnit.Framework;

namespace Day13_14Tasks1_4.Tests
{
    [TestFixture]
    public class BStests
    {
        [Test]
        public void BinarySearchGenericTest_AcceptsEmptyArray_ThrowsException()
        {
            char[] charArray = new char[0];
            Assert.Throws<ArgumentNullException>(() => BinarySearch.BinarySearchGeneric(charArray, 'A', comparison: null));
        }

        [TestCase(new double[] { -1.234, 0, double.MaxValue, double.PositiveInfinity }, double.MinValue)]
        [TestCase(new string[] { "A", "C", "D", "F", "x" }, "Z")]
        public void BinarySearchGenericTest_AcceptsItemOutOfMaxOrMin_ThrowsException<T>(T[] array, T key) => Assert.Throws<ArgumentException>(() => BinarySearch.BinarySearchGeneric(array, key, comparison: null));

        [TestCase(new char[] { 'a', 'n', 'v', 'x', 'z' }, 'v', ExpectedResult = 2)]
        [TestCase(new int[] { int.MinValue, -100, 0, 44, 45, 100, 200 }, 45, ExpectedResult = 4)]
        [TestCase(new string[] { "A", "C", "D", "F", "x", "Y", "Z" }, "Z", ExpectedResult = 6)]
        public int BinarySearchGenericTest<T>(T[] array, T key)
        {
            return BinarySearch.BinarySearchGeneric(array, key, comparison: null);
        }
    }
}
