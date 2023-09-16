namespace Cartsy.Api.Models;

public class StoreForCreationDto
{
    public string Name { get; set; } = string.Empty;
    public AddressDto Address { get; set; }
    public int CustomerId { get; set; }
}