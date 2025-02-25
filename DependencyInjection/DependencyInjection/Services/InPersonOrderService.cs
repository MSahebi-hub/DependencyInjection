using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    class InPersonOrderService : IFoodOrderService
    {
        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine($"In-person order placed: {orderDetails}");
        }
    }
}
