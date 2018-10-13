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

            ~Node()
            {
                Console.Beep();

                Console.WriteLine($"Removed: {Value}");
            }
        }

        private Node Head { get; set; } = null;

        public int Count { get; private set; } = default(int);

        public void Add(T value)
        {
            var node = new Node(value);

            if (Head == null)
            {
                Head = node;
                Count++;
            }
            else
            {
                var current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
                Count++;
            }
        }

        public void Remove(T deletedValue)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(deletedValue))
                {
                    var prev = current;
                    //ALLLO 
                    var next = current.Next;
                    current = null;
                    Count--;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
