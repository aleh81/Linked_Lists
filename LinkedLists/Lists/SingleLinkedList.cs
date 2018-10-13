using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Value { get; }
            public Node Next { get; set; } = null;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node Tail { get; set; } = null;

        public int Count { get; private set; } = default(int);

        public void Add(T value)
        {
            var node = new Node(value);

            if (Tail == null)
            {
                Tail = node;
                Count++;
            }
            else
            {
                var current = Tail;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
                Count++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node current = Tail;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
