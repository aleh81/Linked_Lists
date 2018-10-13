using System;
using System.Collections;
using Lists;

namespace LinkedLists.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingSingleLinkedList();

            Console.ReadKey();
        }

        private static void UsingSingleLinkedList()
        {
            var linkedList = new SingleLinkedList<string>
            {
                "Hello",
                "my",
                "Dear",
                "Friends",
            };

            foreach (var node in linkedList)
            {
                Console.WriteLine(node);
            }

            Console.WriteLine($"Count of elements: {linkedList.Count}");
        }

        private static void Display<T>(T list) where T : IEnumerable
        {
            foreach (var node in list)
            {
                Console.WriteLine(node);
            }
        }
    }
}
