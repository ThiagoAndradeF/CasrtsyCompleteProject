namespace Atividade.Api.Models;

public class StoreWithItemsDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string Name { get; set; } = String.Empty;
    public List<ItemDto> Items { get; set; } = new();
}