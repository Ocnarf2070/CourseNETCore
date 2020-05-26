using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Result "+i);
            }
            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Result " + i);
            }

            Console.WriteLine("\nForEach Loop");
            Console.WriteLine("* Normal For");
            string[] name = { "Alex", "Joel", "PDHN" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Array name at {0}: {1}", i, name[i]);
            }

            Console.WriteLine();
            int[] age = { 52, 45, 65 };
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Name: {0}\tAge: {1}", name[i], age[i]);
            }

            Console.WriteLine("\n* ForEach");
            Console.Write("Array name: ");
            foreach (var item in name)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


        }
    }
}
