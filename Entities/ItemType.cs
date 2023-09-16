// TPT
namespace Cartsy.Api.Entities;

public class ItemType
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public int Tax { get; set; }

    public List<Item> Items { get; set; } = new();

}