using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt16("12");
            double doubles = 2.5;
            string nombre = "Joel";
            string nombres = "Alex Joel";
            decimal decimals = 2.07M;
            float flotante = 8.0F;
            bool valor = true;
            char letra = 'A';
            decimal de = new decimal(28.3); // 28.3M;
            bool valor2 = false; // No contiene contructor Boolean
            Console.WriteLine(nombres + " {0} {1} {2}", year, letra, de);
        }
        // float    7 digitos       32bits
        // double   15-16 digitos   64 bits
        // decimals 28-29 digitos   128 bits
    }
}
