using System;

namespace CSharpPropieties
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var studient = new Studients();
            studient.Name = "Jose"; 

            Console.WriteLine("Name of the studient: "+studient.Name);

        }
    }
}
