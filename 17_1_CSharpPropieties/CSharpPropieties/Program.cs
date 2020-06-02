using System;

namespace CSharpPropieties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Propieties Part 1
            var studient = new Studients();
            //var name = studient.name; Creation simple of the object
            studient.name = "Jose"; // Object now has a proper set

            //Propieties Part 2
            Console.WriteLine("Name of the studient: "+studient.name);//Object now has a proper get

        }
    }
}
