using Interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Repository
{
    public class ProductRepository
    {
        private Dictionary<int,Product> Products;

        public ProductRepository()
        {
            Products = new Dictionary<int, Product>();

            Products.Add(1, new Product
            {
                Id = 1,
                Name = "Coca-Cola Lata 350ml",
                Price = 4.5,
                Category = "Bebidas",
                Supplier = "Vonpar Refrescos"
            });

            Products.Add(2, new Product
            {
                Id = 2,
                Name = "Coca-Cola Zero Lata 350ml",
                Price = 4.5,
                Category = "Bebidas",
                Supplier = "Vonpar Refrescos"
            });

            Products.Add(3, new Product
            {
                Id = 3,
                Name = "Guaraná Lata 350ml",
                Price = 4.5,
                Category = "Bebidas",
                Supplier = "Vonpar Refrescos"
            });

            Products.Add(4, new Product
            {
                Id = 4,
                Name = "Chocolate Neugebauer ao Leite",
                Price = 7.5,
                Category = "Boboniere",
                Supplier = "Vonpar Alimentos"
            });

            Products.Add(5, new Product
            {
                Id = 5,
                Name = "Chocolate Neugebauer Branco",
                Price = 9.5,
                Category = "Boboniere",
                Supplier = "Vonpar Alimentos"
            });

            Products.Add(6, new Product
            {
                Id = 6,
                Name = "Chocolate Neugebauer Amargo",
                Price = 12.5,
                Category = "Boboniere",
                Supplier = "Vonpar Alimentos"
            });
        }

        public IEnumerable<Product> GetAll()
        {
            return Products.Values;
        }

        public Product Get(int id)
        {
            Product product = null;

            Products.TryGetValue(id, out product);

            return product;
        }
    }
}