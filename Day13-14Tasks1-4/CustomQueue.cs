using System;

namespace Day13_14Tasks1_4
{
    public class CustomQueue<T>
    { 
        private T[] array;
        private int head;
        private int tail;
        private int size;
        private int version = 0;

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public CustomQueue()
        {
        }

        /// <summary>
        /// Constructor for queue instance that accepts capacity
        /// </summary>
        /// <param name="capacity">Capacity of sz-array for queue</param>
        public CustomQueue(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            array = new T[capacity];
            head = 0;
            tail = 0;
            size = 0;
        }

        /// <summary>
        /// Property for getting number of queue elements
        /// </summary>
        public int Count => size;

        /// <summary>
        /// Property for getting version of queue
        /// </summary>
        public int Version => version;

        /// <summary>
        /// Method for adding element to the end of queue
        /// </summary>
        /// <param name="item">Element to add</param>
        public void Enqueue(T item)
        {
            array[tail] = item;
            tail = (tail + 1) % array.Length;
            size++;
            version++;
        }

        /// <summary>
        /// Method for removing and returning the object at the beginning of the queue
        /// </summary>
        /// <returns>The object that is removed from the beginning of the queue</returns>
        public T Dequeue()
        {
            T result = array[head];
            array[head] = default(T);
            head = (head + 1) % array.Length;
            size--;
            version++;
            return result;
        }

        /// <summary>
        /// Method for returning the object at the beginning of the queue
        /// </summary>
        /// <returns>The object at the beginning of the queue</returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return array[head];
        }

        /// <summary>
        /// Returns an enumerator that iterates through the queue
        /// </summary>
        /// <returns>Instance of structure for iterating</returns>
        public CustomIterator GetEnumerator()
        {
            return new CustomIterator(this);
        }

        /// <summary>
        /// Struct that contains methods for supporting <see langword="foreach"/> operator
        /// </summary>
        public struct CustomIterator
        {
            private readonly CustomQueue<T> queue;
            private int currentIndex;

            public CustomIterator(CustomQueue<T> collection)
            {
                currentIndex = -1;
                queue = collection;
            }

            /// <summary>
            /// Gets the element in the queue at the current position of the enumerator
            /// </summary>
            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == queue.Count)
                    {
                        throw new InvalidOperationException();
                    }

                    return queue.array[currentIndex];
                }
            }

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection
            /// </summary>
            public void Reset() => currentIndex = -1;

            /// <summary>
            /// Advances the enumerator to the next element of the queue
            /// </summary>
            /// <returns>True if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the queue</returns>
            public bool MoveNext()
            {
                //if (queue.version != version)
                //{
                //    throw new InvalidOperationException();
                //}

                return ++currentIndex < queue.Count;
            }
        }
    }
}
