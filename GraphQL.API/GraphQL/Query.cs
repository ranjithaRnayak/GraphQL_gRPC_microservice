using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Query
{
    public async Task<User> GetUser([Service] GrpcOrderClient grpcClient)
    {
        try
        {
            var orders = await grpcClient.GetOrdersAsync(1);

            return new User
            {
                Id = 1,
                Name = "Potato Rapid",
                Email = "potato@rapidfetch.dev",
                Orders = orders
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine("🔥 Error in GetUser resolver: " + ex.Message);
            Console.WriteLine(ex.StackTrace);
            throw; // rethrow so GraphQL shows error
        }
    }
}

}
