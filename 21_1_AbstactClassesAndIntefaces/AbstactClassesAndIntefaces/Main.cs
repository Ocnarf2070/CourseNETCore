using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactClassesAndIntefaces
{
    // Abstact Class Methods need to specify the visibility (cannot be private).
    // Abstact Class Methods may have the atribute abstact. If it is abstract, it cannot be implemented.
    // IF it is implemented, it cannot be overrided by other classes that extends the Abstract Class.
    public abstract class Main
    {
        public abstract void getProduct();
        public void GetProduct()
        {
            Console.WriteLine("GET PRODUCT 1");
        }
    }
}
