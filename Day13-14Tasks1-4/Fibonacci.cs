using System;
using System.Collections.Generic;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class that contains method for generating Fibonacci numbers
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// Method for generating list of Fibonacci numbers
        /// </summary>
        /// <param name="limit">Maximum value of Fibonacci number</param>
        /// <returns>List of Fibonacci numbers</returns>
        public static List<long> FibonacciGenerator(long limit)
        {
            if (limit <= 0)
            {
                throw new ArgumentException(nameof(limit));
            }

            List<long> fibonacci = new List<long>();
            long first = 0;
            long next = 1;
            fibonacci.Add(first);
            fibonacci.Add(next);
            while (next <= limit)
            {
                long temp = next;
                next += first;
                first = temp;
                fibonacci.Add(next);
            }

            fibonacci.RemoveAt(fibonacci.Count - 1);
            return fibonacci;
        }
    }
}
