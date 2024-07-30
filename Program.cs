using System.ComponentModel;

namespace CS_GetSet005;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        while(true){
            Console.WriteLine("What do you want?");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. View my cart");
            Console.WriteLine("4. Exit");
            int option;
            while(!int.TryParse(Console.ReadLine(), out option) || option < 1  || option > 4)
            {
                Console.WriteLine("Invalid option, Please try again.");
            }
            switch(option)
            {
                case 1:
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter product price");
                    double price;
                    while(!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                    {
                        Console.WriteLine("Invalid price, Please try again.");
                    }
                    Console.WriteLine("Enter product quantity");
                    int quantity;
                    while(!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                    {
                        Console.WriteLine("Invalid quantity, Please try again.");
                    }
                    Product product = new Product(name, price, quantity);
                    cart.AddProduct(product);
                    break;
                case 2:
                    Console.WriteLine("Enter product name you want to remove:");
                    string productName = Console.ReadLine();
                    cart.RemoveProduct(productName);
                    break;
                case 3:
                    cart.ViewCart();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option, exiting...");
                    return;
            }
        }

    }
}
