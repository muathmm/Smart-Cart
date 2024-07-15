using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public List<Product> ViewItems()
        {
            return items;
        }

        public decimal CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }

        public void DisplayCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your shopping cart is empty.");
                return;
            }

            Console.WriteLine("Items in your cart:");
            int index = 1;
            foreach (var item in items)
            {
                Console.WriteLine($" {index}_ {item.Name}     / price: {item.Price}$ ");
                    index++;
            }
            Console.WriteLine($"Total Cost: ${CalculateTotalCost():F2}");
        }
    }
}
