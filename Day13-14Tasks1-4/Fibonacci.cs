using System;
using System.Collections.Generic;
using System.Numerics;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class that contains method for generating Fibonacci numbers
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// Method for generating sequence of Fibonacci numbers
        /// </summary>
        /// <param name="amount">Maximum amount of elements of Fibonacci sequence</param>
        /// <returns>Sequence of Fibonacci numbers</returns>
        public static IEnumerable<BigInteger> FibonacciGenerator(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            long first = 0;
            long next = 1;
            yield return first;
            yield return next;
            for (int i = 2; i < amount; i++)
            {
                long temp = next;
                next += first;
                first = temp;
                yield return next;
            }
        }
    }
}
