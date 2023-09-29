using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prom1LiamTeixido
{
    class ProductCloth : IProduct, IMaterial
    {
        private string name;
        private int size;
        private string color;
        private int price;

        public ProductCloth(string name, int size, string color, int price)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            this.price = price;
        }

        public string GetFeatures()
        {
            return $"Nombre: {name}, Tamaño: {size}, Color: {color}, Precio: {price}";
        }

        public string GetName()
        {
            return "Tela";
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
