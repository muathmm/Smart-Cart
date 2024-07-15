using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class GroceryStore
    {
        private List<Product> products;

        public GroceryStore()
        {
            products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(ProductGenerator.GenerateProduct(ProductCategory.Food));
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Grocery Store Products:");
            int index = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{index}.  {product.Name}  /  price:{product.Price}");
                index++;
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
