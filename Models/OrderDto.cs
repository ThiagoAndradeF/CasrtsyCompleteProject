namespace Cartsy.Api.Models;

public class OrderDto
{
    public int ConsumerId { get; set; }
    public string ConsumerName { get; set; }
    public double Price { get; set;}
    public DateTime Date { get; set; }
    public List<ItemDto> Items { get; set; } = new();
    public StatusDto Status { get; set; }
}