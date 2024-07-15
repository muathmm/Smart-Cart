using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ClothingStore
    {
        private List<Product> products;

        public ClothingStore()
        {
            products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(ProductGenerator.GenerateProduct(ProductCategory.Clothing));
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Clothing Store Products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}   / price: {products[i].Price}");
            }
        }

        public Product SelectProduct(int index)
        {
            if (index < 1 || index > products.Count)
            {
                Console.WriteLine("Invalid product selection");
            }
            return products[index - 1];
        }
    }
}
