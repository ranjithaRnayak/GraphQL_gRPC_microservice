using GraphQL.API.GraphQL;
using GraphQL.API.Services;
using Grpc.Net.ClientFactory;
using RapidFetch.OrderService;

var builder = WebApplication.CreateBuilder(args);

// gRPC client to gRPC.OrderService
 builder.Services.AddGrpcClient<OrderService.OrderServiceClient>(o =>
{
     o.Address = new Uri("http://localhost:5207"); // or your gRPC service URL
 });

builder.Services.AddSingleton<GrpcOrderClient>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();
app.Run();
