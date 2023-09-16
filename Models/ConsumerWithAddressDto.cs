using Cartsy.Api.Entities;

namespace Cartsy.Api.Models;

public class ConsumerWithAdressDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Status { get; set; }
    public AddressDto Address { get; set; }
    public string CPF { get; set; } = string.Empty;
}
