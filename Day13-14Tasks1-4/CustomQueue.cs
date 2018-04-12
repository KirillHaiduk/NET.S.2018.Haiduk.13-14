using System;
using System.Collections;
using System.Collections.Generic;

namespace Day13_14Tasks1_4
{
    public class CustomQueue<T> : IEnumerable<T>, ICollection, IEnumerable
    {
        private T[] array;
        private int head;
        private int tail;
        private int size;

        public CustomQueue()
        {
        }

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

        public int Count => size;

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => false;

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {
            array[tail] = item;
            tail = (tail + 1) % array.Length;
            size++;
        }

        public T Dequeue()
        {
            T result = array[head];
            array[head] = default(T);
            head = (head + 1) % array.Length;
            size--;
            return result;
        }

        public T Peek() => array[head];
    }
}
