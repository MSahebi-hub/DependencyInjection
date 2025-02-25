using DependencyInjection.Interfaces;

namespace DependencyInjection
{
    class OrderProcessor
    {
        private readonly IOrderService _orderService;
        private readonly IFoodOrderService _foodOrderService;

        public OrderProcessor(IOrderService orderService, IFoodOrderService foodOrderService)
        {
            _orderService = orderService;
            _foodOrderService = foodOrderService;
        }

        public void ProcessOnlineOrPhoneOrder(string customerName, string foodItem)
        {
            _orderService.PlaceOrder(customerName, foodItem);
        }

        public void ProcessInPersonOrder(string orderDetails)
        {
            _foodOrderService.PlaceOrder(orderDetails);
        }
    }
}
