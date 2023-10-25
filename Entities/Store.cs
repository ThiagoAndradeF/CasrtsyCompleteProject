namespace Cartsy.Api.Entities;

public class Store
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int? AddressId { get; set;}
    public Address? Address { get; set; }
    public List<AdditionalServices> Services { get; set; } = new();
    public List<Order> Orders { get; set; } = new();
    public List<Item> Items { get; set; } = new();
}