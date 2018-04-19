using System;
using System.Collections.Generic;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class that contains method for Binary search in sorted array of generic type items
    /// </summary>
    public static class BinarySearch
    {
        #region Public methods

        /// <summary>
        /// Method that implements binary search in sorted array of generic type items
        /// </summary>
        /// <typeparam name="T">T parameter type</typeparam>
        /// <param name="array">Sorted array of T type items</param>
        /// <param name="key">Item to search</param>
        /// <param name="comparer">Instance of IComparer interface type</param>
        /// <returns>Number of position of wanted element in given array</returns>        
        public static int BinarySearchGeneric<T>(this T[] array, T key, ICustomComparer<T> comparer)
        {
            InputValidation(array, key, comparer.Compare);

            if (comparer is null)
            {
                if (key is IComparable && array[0] is IComparable)
                {
                    return BinarySearchGeneric(array, key, Comparer<T>.Default.Compare);
                }
                else
                {
                    throw new ArgumentException(nameof(comparer));
                }
            }

            return BinarySearchGeneric(array, key, comparer.Compare);            
        }

        /// <summary>
        /// Method that implements binary search in sorted array of generic type items
        /// </summary>
        /// <typeparam name="T">T parameter type</typeparam>
        /// <param name="array">Sorted array of T type items</param>
        /// <param name="key">Item to search</param>
        /// <param name="comparison">Delegate as comparison type</param>
        /// <returns>Number of position of wanted element in given array</returns>
        public static int BinarySearchGeneric<T>(this T[] array, T key, Comparison<T> comparison)
        {
            InputValidation(array, key, comparison);
            int first = 0;
            int last = array.Length;
            while (first < last)
            {
                int middle = first + ((last - first) / 2);
                if (comparison(key, array[middle]) <= 0)
                {
                    last = middle;
                }
                else
                {
                    first = middle + 1;
                }
            }

            if (comparison(array[last], key) == 0)
            {
                return last;
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region Private methods

        private static void InputValidation<T>(T[] array, T key, Comparison<T> comparison)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (comparison is null)
            {
                throw new ArgumentException(nameof(comparison));
            }

            if (comparison(key, array[0]) < 0 || comparison(key, array[array.Length - 1]) > 0)
            {
                throw new ArgumentException(nameof(key));
            }
        }

        #endregion
    }
}
