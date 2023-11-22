// TPT
namespace Atividade.Api.Entities;

public class OrderStatus
{
    public int Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public List<Order> Orders { get; set; } = new();
}