using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    class Sweeties : Storage
    {
        private List<Product> _Sweeties;
        public Sweeties()
        {
            _Sweeties = new List<Product>();
        }
        public override void AddProduct(Product product)
        {
            _Sweeties.Add(product);
        }

        public override Product GetProduct(string product)
        {
            int i = 0;
            while (i < _Sweeties.Count && !_Sweeties[i].Name.Equals(product)) i++;
            var sweet = i < _Sweeties.Count ? _Sweeties[i] : null;
            return sweet;
            //return _Sweeties.Where(s => s.Name.Equals(product)).ToList()[0];
        }

        public override List<Product> GetProducts()
        {
            return _Sweeties;
        }
    }
}
