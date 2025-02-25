namespace DependencyInjection.Interfaces
{
    interface IOrderService
    {
        void PlaceOrder(string customerName, string foodItem);
    }
}
