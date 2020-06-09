using System;

namespace LinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 2, 4, 1, 3, 5, 4 };
            LinkedListN list = new LinkedListN();
            EmptyList(list);
            foreach (var item in items)
            {
                list.Add(item);
                Console.WriteLine(list);
            }
        }
        public static void EmptyList(LinkedListN list)
        {
            if (list.IsEmpty()) Console.WriteLine("The list is empty");
            else Console.WriteLine("The list has elements");
        }
    }
}
