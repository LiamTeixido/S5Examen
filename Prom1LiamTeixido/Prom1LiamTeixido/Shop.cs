using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prom1LiamTeixido
{
    class Shop
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public int CalculateFinalPrice()
        {
            int total = 0;
            foreach (var producto in products)
            {
                total += producto.GetPrice();
            }
            return total;
        }

        public List<IProduct> GetProducts()
        {
            return products;
        }

        public void ShowProducts()
        {
            Console.WriteLine("Contenido del carrito de compras:");


            foreach (var product in products)
            {
                Console.WriteLine($"{product.GetFeatures()}");
            }
            Console.WriteLine($"Precio Total: {CalculateFinalPrice():C}");
        }

        public void ClearShoppingCar()
        {
            products.Clear();
        }
    }
}
