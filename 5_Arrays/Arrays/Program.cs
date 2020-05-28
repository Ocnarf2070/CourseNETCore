using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array String");
            string[] cadenas = new string[5];
            Console.WriteLine("* Array cadenas");
            Console.WriteLine("Array length: "+cadenas.Length);
            cadenas[4] = "Alex";
            Console.WriteLine("Array at 4: " + cadenas[4]);
            cadenas[0] = "Joel";
            cadenas[1] = "PDHN";
            cadenas[2] = "Seidy";
            cadenas[3] = "Cindy";
            Console.WriteLine("Array at 0: " + cadenas[0]);
            Console.WriteLine("Array at 0 and 3: " + cadenas[0]+" "+cadenas[3]);
            string[] name = { "Joel", "PDHN", "Seidy", "Cindy", "Alex" };
            Console.WriteLine("* Array name");
            Console.WriteLine("Array at 0 and 3: " + name[0] + " " + name[3]);

            Console.WriteLine("\nArray Int");
            int[] age = new int[5];
            age[0] = 5;
            age[1] = 15;
            age[2] = 50;
            age[3] = 55;
            age[4] = 95;
            Console.WriteLine("* Array age");
            Console.WriteLine("Name: {0}\tAge: {1}",name[0] + " " + name[3], age[2]);
            int[] ages = { 8, 9, 56, 14, 5 };
            Console.WriteLine("* Array ages");
            Console.WriteLine("Name: {0}\tAge: {1}", name[0] + " " + name[3], ages[2]);

            Console.WriteLine("\nMultidimensional Array");
            //Array bidimensional
            double[,] doble2 = new double[2, 2] { { 6, 3.0 }, { 6.3, 5.6 } };
            Console.WriteLine("* Array doble2");
            Console.WriteLine("Array at (0,0) : " + doble2[0, 0]);
            Console.WriteLine("Array at (0,1) : " + doble2[0, 1]);
            Console.WriteLine("Array at (1,0) : " + doble2[1, 0]);
            Console.WriteLine("Array at (1,1) : " + doble2[1, 1]);

            //Array tridimensional
            double[,,] doble3 = new double[2, 2, 3] { { { 3.0, 6.9, 8.9 }, { 6.8, 4.5, 7.6 } }, { { 6.0, 6.8, 2.9 }, { 3.8, 4.5, 10.6 } } };
            Console.WriteLine("* Array doble3");
            Console.WriteLine("Array at (0,1,2) : " + doble3[0, 1, 2]);

        }
    }
}
