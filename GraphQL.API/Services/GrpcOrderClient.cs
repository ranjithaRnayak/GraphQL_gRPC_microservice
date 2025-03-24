using RapidFetch.OrderService;

namespace GraphQL.API.Services
{
    public class GrpcOrderClient
    {
        private readonly OrderService.OrderServiceClient _client;

         public GrpcOrderClient(OrderService.OrderServiceClient client)
         {
             _client = client;
         }

        public async Task<List<Models.Order>> GetOrdersAsync(int userId)
        {
             var response = await _client.GetOrdersAsync(new OrderRequest { UserId = userId });
             return response.Orders
                           .Select(o => new Models.Order(o.OrderId, o.Amount, o.Status))
                            .ToList();
        }
    }
}
