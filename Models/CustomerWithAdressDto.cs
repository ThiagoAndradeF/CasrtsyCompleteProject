using Cartsy.Api.Entities;

namespace Cartsy.Api.Models;

public class CustomerWithAdressDto
{

    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? CPF { get; set; }
    public string? CNPJ { get; set; }
    public bool Status { get; set; }
    
    public AddressDto Address { get; set; }
}