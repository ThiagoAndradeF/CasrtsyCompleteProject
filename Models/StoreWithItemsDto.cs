namespace Cartsy.Api.Models;

public class StoreWithItemsDto
{
    public string CustomerName { get; set; } = string.Empty;
    public string Name { get; set; } = String.Empty;
    public List<ItemDto> Items { get; set; } = new();
}