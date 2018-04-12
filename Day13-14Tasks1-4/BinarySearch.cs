using System;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class that contains method for Binary search in sorted array of generic type items
    /// </summary>
    public static class BinarySearch
    {
        /// <summary>
        /// Method that implements binary search in sorted array of generic type items
        /// </summary>
        /// <typeparam name="T">T parameter type which is limited by types implementing <see cref="IComparable"/> interface</typeparam>
        /// <param name="array">Sorted array of T items</param>
        /// <param name="key">Item to search</param>
        /// <returns>Number of position of wanted element in given array</returns>
        public static int BinarySearchGeneric<T>(T[] array, T key) where T : IComparable
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException(nameof(array));
            }            
            
            if (key.CompareTo(array[0]) < 0 || key.CompareTo(array[array.Length - 1]) > 0)
            {
                throw new ArgumentException(nameof(key));
            }

            int first = 0;
            int last = array.Length;
            while (first < last)
            {
                int middle = first + ((last - first) / 2);
                if (key.CompareTo(array[middle]) <= 0)
                {
                    last = middle;
                }
                else
                {
                    first = middle + 1;
                }
            }

            if (array[last].CompareTo(key) == 0)
            {
                return last;
            }
            else
            {
                return -1;
            }
        }
    }
}
