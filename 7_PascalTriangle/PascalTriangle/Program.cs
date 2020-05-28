using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors;
            int[] aux = new int [1];
            Console.Write("Insert the number of floors: ");
            floors = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= floors; i++)
            {
                int[] pascal = new int[i];
                for (int j = floors; j > i; j--) Console.Write(" ");
                for (int k = 0; k < i; k++)
                {
                    if (k == 0 || k == (i - 1)) pascal[k] = 1;
                    else pascal[k] = aux[k] + aux[k - 1];
                    Console.Write("{0} ",pascal[k]);
                }
                aux = pascal;
                Console.WriteLine();
            }
            
        }
    }
}
