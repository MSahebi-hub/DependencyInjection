using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    class OnlineOrderService : IOrderService
    {
        public void PlaceOrder(string customerName, string foodItem)
        {
            Console.WriteLine($"Online order placed by {customerName} for {foodItem}");
        }
    }
}
