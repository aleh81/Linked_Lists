using System;
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

            linkedList.Remove("Dear");

            foreach (var node in linkedList)
            {
                Console.WriteLine(node);
            }

            Console.WriteLine($"Count of elements: {linkedList.Count}");
        }
    }
}
