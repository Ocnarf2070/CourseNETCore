using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Menu
    {   
        //Part 1
        public void getProduct()
        {
            Console.WriteLine("getProduct");
        }

        //Part 2
        private string s;

        public Menu(string s)
        {
            this.s = s;
        }

        protected virtual void GetProduct()
        {
            Console.WriteLine(s);
        }


    }
}
