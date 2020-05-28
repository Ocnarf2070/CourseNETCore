using System;
using System.Text;

namespace StringBuilderExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // First part
            StringBuilder names = new StringBuilder("Javier Sara");
            Console.WriteLine("Original String: " + names.ToString());
            names[0] = 'j';
            Console.WriteLine("Replace first char: " + names.ToString());
            names.Append(" Elisa");
            Console.WriteLine("Append a new String: " + names.ToString());
            Console.WriteLine("Lenght of String: " + names.Length);
            // names.Capacity = 17; Defines the capacity of the StringBuilder. If it is less than the lenght of the string, it raise an exception.

            // Second part
            names.Append(" ").Append("Manuel");
            Console.WriteLine("State of the String: " + names.ToString());
            StringBuilder names2 = new StringBuilder("Javier Sara");
            names2.AppendLine().Append("Elisa").Append(" ").Append("Manuel");
            Console.WriteLine("Append a new line: \n" + names2.ToString());
            names2.AppendFormat("\nAge {0}", 50);
            Console.WriteLine("Append a formated string: \n" + names2.ToString());


        }
    }
}
