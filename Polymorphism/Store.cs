using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Store
    {
        public Product[] Products;
        public void AddProduct(Product product)
        {
            
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public void GetDrinkProducts()
        {

        }
        public void GetDairyProducts()
        {

        }
    }
}
