using System;

namespace MethodParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass an Object array as parameter");
            object[] parameters = { "Jose", 23, true };
            Console.WriteLine("Type of the array: "+parameters);
            new Program().method(parameters);

            Console.WriteLine("\nKeywords: params and in");
            new Program().method2("Jose", 23, true, 'A');
            int age = 30;
            new Program().method3_1(age);
            new Program().method3_2(age);
            new Program().method3_2(67);

            Console.WriteLine("\nKeywords: ref and out");
            int data = 67;
            Console.WriteLine("* ref");
            Console.WriteLine("Original value: "+data);
            new Program().method4(ref data);
            Console.WriteLine("After the method: "+data);
            Console.WriteLine("* out");
            int data2;
            new Program().method5(out data2);
            Console.WriteLine("After the method: " + data2);


        }

        //Part 1
        private void method(object[] parameters)
        {
            string name = (string)parameters[0];
            int age = (int)parameters[1];
            bool value = (bool)parameters[2];
            Console.WriteLine($"{name} {age} {value}"); 
        }

        //Part 2
        private void method2(params object[] parameters)
        {
            foreach (var p in parameters) Console.Write($"{p} ");
            Console.WriteLine();
        }

        private void method3_1(int value)
        {
            Console.WriteLine(value);
        }
        private void method3_2(in int value)
        {
            //value = 50; Cannot be modified due to it is an only read variable
            Console.WriteLine(value);
        }

        //Part 3
        private void method4(ref int value)
        {
            value += 20;
        }

        private void method5(out int value)
        {
            value = 50 + 20;
        }
    }
}
