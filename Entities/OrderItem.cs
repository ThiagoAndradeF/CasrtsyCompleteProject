// TPT
namespace Atividade.Api.Entities;

public class OrderItem
{
    public int OrderId { get; set; }
    public Order Order { get; set; } = default!;
    public int ItemId { get; set; }
    public Item Item  { get; set; } = default!;

    public DateTime CreatedAt { get; set; }

    
}