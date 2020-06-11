using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public abstract class Storage
    {
        public abstract List<Product> GetProducts();
        public abstract Product GetProduct(string product);
        public abstract void AddProduct(Product product);
    }
}
