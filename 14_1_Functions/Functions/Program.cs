using System;
using System.ComponentModel.DataAnnotations;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funtions");
            int data;
            new Program().method(out data);
            Console.WriteLine("Value of data: "+data);
            int data2;
            new Program().method2(out data2);
            Console.WriteLine("Value of data2: "+data2);

            Console.WriteLine("\nStatic Funtions");
            int data3;
            new Program().method3(out data3);
            Console.WriteLine("Value of data3: " + data3);
            message();
            void message() => Console.WriteLine("Message => Value of data3: " + data3);

            string name;
            message2();
            Console.WriteLine($"Value of name: {name}");
            void message2() => name = "Jose Garcia";

        }

        //Part 1
        private void method(out int value)
        {
            value = 50 + 20;
            function(value);
            void function(int value)
            {
                Console.WriteLine($"This is a function.\nThe value of data is {value}.");
            }
        }
        private void method2(out int value)
        {
            value = function();
            int function()
            {
                return 50 + 60;
            }
        }

        //Part 2
        private void method3(out int value)
        {
            value = function();
            static int function() => 50 + 60;
            
        }


    }

}
