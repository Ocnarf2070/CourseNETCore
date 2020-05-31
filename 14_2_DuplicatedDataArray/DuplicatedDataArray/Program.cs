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
                if (aux[i] != 0) Console.WriteLine($"{aux[i]} se repite: {count}");
            }
            bool number(int num)
            {
                for (int i = 0; i < aux.Length; i++)
                {
                    if (aux[i] == num) return false;
                }
                return true;
            }
            
        }
    }
}
