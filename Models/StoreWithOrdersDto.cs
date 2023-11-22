namespace Atividade.Api.Models;

public class StoreWithOrdersDto
{
    public string CustomerName { get; set; } = string.Empty;
    public string Name { get; set; } = String.Empty;
    public List<OrderDto> Orders { get; set; } = new();
}