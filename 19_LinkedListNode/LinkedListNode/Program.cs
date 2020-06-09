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
            list.Delete(5);
            Console.WriteLine(list);
            list.DeleteLast();
            Console.WriteLine(list);
            list.DeleteByPosition(30);
            list.DeleteByPosition(2);
            Console.WriteLine(list);
            Console.WriteLine(list.Search(3));
            Console.WriteLine(list.Search(5));
            Console.WriteLine(list.Search(2));
            Console.WriteLine(list.Search(4));
            list.Replace(3, 6);
            Console.WriteLine(list);


        }
        public static void EmptyList(LinkedListN list)
        {
            if (list.IsEmpty()) Console.WriteLine("The list is empty");
            else Console.WriteLine("The list has elements");
        }
    }
}
