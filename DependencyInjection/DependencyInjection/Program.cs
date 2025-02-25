using DependencyInjection.Services;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? choice = null;
            while (string.IsNullOrWhiteSpace(choice) || (choice != "1" && choice != "2" && choice != "3"))
            {
                Console.WriteLine("\nChoose your order method (1/2/3): ");
                Console.WriteLine("1. Online Order");
                Console.WriteLine("2. Phone Order");
                Console.WriteLine("3. In-Person Order");
                choice = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(choice) || (choice != "1" && choice != "2" && choice != "3"))
                {
                    Console.WriteLine("Invalid input. Please select a valid option (1, 2, or 3).");
                }
            }

            OrderProcessor orderProcessor = null;

            if (choice == "1")
            {
                orderProcessor = new OrderProcessor(new OnlineOrderService(), new InPersonOrderService());
                Console.Write("Enter your name: ");
                string customerName = Console.ReadLine();
                Console.Write("Enter food item: ");
                string foodItem = Console.ReadLine();
                orderProcessor.ProcessOnlineOrPhoneOrder(customerName, foodItem);
            }
            else if (choice == "2")
            {
                orderProcessor = new OrderProcessor(new PhoneOrderService(), new InPersonOrderService());
                Console.Write("Enter your name: ");
                string customerName = Console.ReadLine();
                Console.Write("Enter food item: ");
                string foodItem = Console.ReadLine();
                orderProcessor.ProcessOnlineOrPhoneOrder(customerName, foodItem);
            }
            else if (choice == "3")
            {
                orderProcessor = new OrderProcessor(new OnlineOrderService(), new InPersonOrderService());
                Console.Write("Enter your order details: ");
                string orderDetails = Console.ReadLine();
                orderProcessor.ProcessInPersonOrder(orderDetails);
            }

            Console.WriteLine("\nOrder processed successfully!");
            Console.ReadKey();
        }
    }
}
