using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Fruits : Storage
    {
        private List<Product> _Fruits;
        public Fruits()
        {
            _Fruits = new List<Product>();
        }
        public override void AddProduct(Product product)
        {
            _Fruits.Add(product);
        }

        public override Product GetProduct(string product)
        {
            int i = 0;
            while (i < _Fruits.Count && !_Fruits[i].Name.Equals(product)) i++;
            var fruit = i < _Fruits.Count ? _Fruits[i] : null;
            return fruit;
        }

        public override List<Product> GetProducts()
        {
            return _Fruits;
        }
    }
}
