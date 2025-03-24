using RapidFetch.OrderService;

var builder = WebApplication.CreateBuilder(args);


// ✅ THIS is the missing line causing the crash
builder.Services.AddGrpc();

var app = builder.Build();

// ✅ Register the gRPC implementation here
app.MapGrpcService<OrderServiceImpl>();

app.Run();
