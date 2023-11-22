namespace Atividade.Api.Models;

public class OrderDto
{
    public int ConsumerId { get; set; }
    public string ConsumerName { get; set; } =String.Empty;
    public double Price { get; set;}
    public DateTime Date { get; set; }
    public List<ItemDto> Items { get; set; } = default!;
    public StatusDto Status { get; set; } = default!;
}