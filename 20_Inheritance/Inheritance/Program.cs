using System;

namespace Inheritance
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class-based Inheritance");
            new Program("").getProduct(); //If the father class method is not public, it cannot be called by their childs

            Console.WriteLine("Keywords: protected, base, override and virtual");
            new Program("Empresa: ADA").GetProduct(); //Although is not a public method, the child can access because it protected. Only child from the father class can access this method
        }

        //Part 2
        public Program(String s) : base(s)
        {

        }
        protected override void GetProduct()
        {
            Console.WriteLine("GetProductOverrided");
        }
    }
}
