using Grpc.Core;
using RapidFetch.OrderService;
public class OrderServiceImpl : OrderService.OrderServiceBase
{
    public override Task<OrderResponse> GetOrders(OrderRequest request, ServerCallContext context)
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 201, Amount = 75.00, Status = "Delivered" },
            new Order { OrderId = 202, Amount = 120.45, Status = "Processing" }
        };

        return Task.FromResult(new OrderResponse { Orders = { orders } });
    }
}
