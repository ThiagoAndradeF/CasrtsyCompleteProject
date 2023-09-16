using Cartsy.Api.Entities;

namespace Cartsy.Api.Models;

public class AddressDto
{
    public string Street { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public int Number { get; set; }
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string UF { get; set; } = string.Empty;
}