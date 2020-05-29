using System;

namespace MethodOverloading
{
    class Program
    {
        public Program() //Empty Constructor
        {

        }
        public Program(string name) //Overloaded Constructor
        {

        }
        public Program(string name, int age) //Second Overloaded Constructor
        {

        }
        public Program(int age, string name) //Inverted Second Overloaded Constructor 
        {

        }
        static void Main(string[] args)
        {
            var data = new Program(); // Execute the Empty Constructor
            var data2 = new Program("Rio"); // Execute the Overloaded Constructor
            var data3 = new Program("Jose", 23); // Execute the Second Overloaded Constructor
            var data4 = new Program(23, "Jose"); // Execute the Inverted Second Overloaded Constructor

            Console.WriteLine("Hello World!");
        }
    }
}
