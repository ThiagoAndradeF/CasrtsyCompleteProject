namespace Atividade.Api.Models;

public class OrderDto
{
    public int StoreId { get; set; }
    public string ConsumerName { get; set; } = string.Empty;
    public double Price { get; set;}
    public DateTime DateCreated { get; set; }
    public List<int> ItemIds { get; set; } = default!;
    public List<int> ServiceIds = default!;
}