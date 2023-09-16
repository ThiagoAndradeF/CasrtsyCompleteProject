// TPT
namespace Cartsy.Api.Entities;

public class Consumer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int AddressId { get; set; }
    public bool Status { get; set; }
    public Address Address { get; set; }
    public string CPF { get; set; } = string.Empty;
    public List<Order> Orders { get; set; } = new();
}