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

            return FibonacciHelper(amount);
        }

        private static IEnumerable<BigInteger> FibonacciHelper(int amount)
        {
            BigInteger first = -1;
            BigInteger next = 1;            
            for (int i = 0; i < amount; i++)
            {
                BigInteger temp = next;
                next += first;
                first = temp;
                yield return next;
            }
        }
    }
}
