namespace Smart_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Smart Shopping Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Checkout and Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        cart.DisplayCart();
                        RemoveItemFromCart(cart);
                        break;
                    case "4":
                        Console.WriteLine($"Total Cost: ${cart.CalculateTotalCost():F2}");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("Select a product to add to your cart (enter number): ");
            if (int.TryParse(Console.ReadLine(), out int productIndex))
            {
                try
                {
                    var product = store.SelectProduct(productIndex);
                    cart.AddItem(product);
                    Console.WriteLine($"{product.Name} has been added to your cart.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        private static void RemoveItemFromCart(ShoppingCart cart)
        {
            Console.WriteLine("Do you want to remove an item from the cart? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.Write("Select a product to remove from your cart (enter number): ");
                if (int.TryParse(Console.ReadLine(), out int productIndex))
                {
                    var items = cart.ViewItems();
                    if (productIndex >= 1 && productIndex <= items.Count)
                    {
                        var product = items[productIndex - 1];
                        cart.RemoveItem(product);
                        Console.WriteLine($"{product.Name} has been removed from your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product selection.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
        }
}
