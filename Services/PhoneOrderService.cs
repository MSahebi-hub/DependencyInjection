using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    class PhoneOrderService : IOrderService
    {
        public void PlaceOrder(string customerName, string foodItem)
        {
            Console.WriteLine($"Phone order placed by {customerName} for {foodItem}");
        }
    }
}
