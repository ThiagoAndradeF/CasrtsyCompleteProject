namespace Cartsy.Api.Entities;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set;}
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public int TypeId { get; set; }
    public ItemType Type { get; set; }
    public List<Order> Orders { get; set; } = new ();

}