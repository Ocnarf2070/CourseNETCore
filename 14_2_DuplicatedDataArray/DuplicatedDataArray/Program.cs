using System;
using System.Collections.Generic;

namespace DuplicatedDataArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 6, 4, 4, 4, 9, 5, 6, 5, 9, 2 };
            int[] aux = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (number(array[i])) aux[i] = array[i];
                    }
                }
                if (aux[i] != 0) Console.WriteLine($"{aux[i]} repeats {count} time{isPlural(count)}");
            }
            string isPlural(int num) => num == 1 ? "" : "s";
            bool number(int num)
            {
                int i = 0;
                while (i < aux.Length && aux[i] != num) i++;
                return i >= aux.Length;
            }
            
        }
    }
}
