using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Product
    {
        protected static int nextID = 0;
        private int _id;
        public int ID { 
            get => _id;
        }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() => _id = ++nextID;
    }
}
