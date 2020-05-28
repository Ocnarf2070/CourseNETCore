using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop");
            int count = 0;
            while (count <= 6)
            {
                Console.WriteLine("Execution " + count);
                count++;
            }

            Console.WriteLine("\nDoWhile Loop");
            count = 0;
            do
            {
                Console.WriteLine("Execution " + count);
                count++;
            } while (count<=6);

        }
    }
}
