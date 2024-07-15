using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        
    private static Random random = new Random();
        private static string[] foodNames = { "Apple", "Banana", "Carrot", "Bread", "Milk" };
        private static string[] clothingNames = { "T-Shirt", "Jeans", "Jacket", "Hat", "Shoes" };
        private static string[] electronicsNames = { "Smartphone", "Laptop", "TV", "Headphones", "Camera" };

        public static Product GenerateProduct(ProductCategory category)
        {
            string name;
            decimal price;

            switch (category)
            {
                case ProductCategory.Food:
                    name = foodNames[random.Next(foodNames.Length)];
                    price = (decimal)(random.Next(50, 1000) / 100.0);
                    break;
                case ProductCategory.Clothing:
                    name = clothingNames[random.Next(clothingNames.Length)];
                    price = (decimal)(random.Next(500, 5000) / 100.0);
                    break;
                case ProductCategory.Electronics:
                    name = electronicsNames[random.Next(electronicsNames.Length)];
                    price = (decimal)(random.Next(5000, 100000) / 100.0);
                    break;
                default:
                    throw new ArgumentException("Invalid product category");
            }

            return new Product(name, price, category);
        }
    }
}
