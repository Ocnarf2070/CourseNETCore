using System;
using System.ComponentModel;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aritmetic Operators
            Console.WriteLine("Aritmetic Operators");
            int valor1 = 3;
            int valor2 = 6;
            var suma = valor1 + valor2;
            var resta = valor1 - valor2;
            var mult = valor1 * valor2;
            var div = (double)valor1 / valor2;
            var modulo = valor1 % valor2;
            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, suma);
            Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resta);
            Console.WriteLine("{0} * {1} = {2}", valor1, valor2, mult);
            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, div);
            Console.WriteLine("{0} mod({1}) = {2}", valor1, valor2, modulo);

            //Assignment Operators
            Console.WriteLine("\nAssignment Operators");
            valor1 = 9;
            valor2 = 2;
            Console.WriteLine("Original values\tValor1: {0}\tValor2: {1}", valor1, valor2);
            valor1 += valor2;
            Console.WriteLine("Valor1+=Valor2\tValor1: {0}\tValor2: {1}", valor1, valor2);
            valor1 -= valor2;
            Console.WriteLine("Valor1-=Valor2\tValor1: {0}\tValor2: {1}", valor1, valor2);
            valor2 *= valor1;
            Console.WriteLine("Valor2*=Valor1\tValor1: {0}\tValor2: {1}", valor1, valor2);
            valor2 /= valor1;
            Console.WriteLine("Valor2/=Valor1\tValor1: {0}\tValor2: {1}", valor1, valor2);
            valor1 %= valor2;
            Console.WriteLine("Valor1%=Valor2\tValor1: {0}\tValor2: {1}", valor1, valor2);

            //Relational and Type Checking Operators
            Console.WriteLine("\nRelational and Type Checking Operators");
            valor1 = 9;
            valor2 = 2;
            var data = valor1 < valor2;
            Console.WriteLine("{0} < {1} : {2}", valor1, valor2, data);
            data = valor1 > valor2;
            Console.WriteLine("{0} > {1} : {2}", valor1, valor2, data);
            data = valor2 >= valor1;
            Console.WriteLine("{1} >= {0} : {2}", valor1, valor2, data);
            valor2 = 9;
            data = valor2 >= valor1;
            Console.WriteLine("{1} >= {0} : {2}", valor1, valor2, data);
            data = valor2 <= valor1;
            Console.WriteLine("{1} <= {0} : {2}", valor1, valor2, data);

            //Equality Operators
            Console.WriteLine("\nEquality Operators");
            valor1 = 10;
            valor2 = 9;
            data = valor1 == valor2;
            Console.WriteLine("{0} == {1} : {2}", valor1, valor2, data);
            data = valor1 != valor2;
            Console.WriteLine("{0} != {1} : {2}", valor1, valor2, data);
            valor1 = 9;
            data = valor1 != valor2;
            Console.WriteLine("{0} != {1} : {2}", valor1, valor2, data);
            
        }
    }
}
