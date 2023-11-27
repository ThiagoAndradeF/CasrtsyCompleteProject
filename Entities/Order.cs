
namespace Atividade.Api.Entities;

public class Order
{
    public int Id { get; set; }
    public double Price { get; set; }
    public DateTime DateCreated { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; } = default!;
    public List<AdditionalServices> Services { get; set; } = default!;
    public List<Item> Items { get; set; } = new();
    public string ConsumerName { get; set; } = string.Empty;
}