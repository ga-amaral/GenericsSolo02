using System;
using System.Collections.Generic;
using System.Text;
using GenericsSolo02.Service;

namespace GenericsSolo02.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is no a product");
            }
            /*DownCast do obj para Product
            Porquê dessa forma ele pode chamar o preço*/
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2");
        }

    }
}
