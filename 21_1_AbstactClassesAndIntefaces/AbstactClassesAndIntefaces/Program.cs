using System;

namespace AbstactClassesAndIntefaces
{
    class Program : Menu
    {    
        public Program(String s) : base(s)
        {

        }
        static void Main(string[] args)
        {
            new Program("Empresa: ADA").getProduct();

        }

        //public override void getProduct()
        //{
        //    Console.WriteLine("GetProductOverrided");
        //}
    }
}
