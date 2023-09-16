
namespace Cartsy.Api.Entities;

public class Order
{
    public int Id { get; set; }
    public double Price { get; set; }
    public DateTime DateDelivered { get; set; }
    public DateTime DateCreated { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    
    public List<Item> Items { get; set; } = new();
    public int StatusId { get; set; }
    public OrderStatus Status { get; set; }
    public int ConsumerId { get; set; }
    public Consumer Consumer { get; set; }
}