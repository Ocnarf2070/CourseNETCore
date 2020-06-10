using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactClassesAndIntefaces
{
    //Classes only extend another class, but can implement as many interfaces as it wants. 
    public class Menu : Main, IProduct
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
            base.GetProduct();
        }

        public void addProduct()
        {
            throw new NotImplementedException();
        }
        public void addProduct(int p)
        {

        }

        public override void getProduct()
        {
            Console.WriteLine(s);
        }

        // It is not allowed due to its property which lacks of keyword virtual or abstract from the father class
        //public override void GetProduct() 
        //{

        //}


    }

    //If an Inteface Method is implemented, the classes that implemets the intefaces do not need to implement the same method.
    //Interfaces do not have to declarate their visibility nor if it is abstract
    interface IProduct
    {
        void addProduct();
        void addProduct(int p)
        {

        }
    }
}
