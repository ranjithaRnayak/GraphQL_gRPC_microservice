namespace GraphQL.API.Models
{
    public record Order(int OrderId, double Amount, string Status);

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new();
    }
}
