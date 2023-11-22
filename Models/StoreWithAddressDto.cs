namespace Atividade.Api.Models;

public class StoreWithAddressDto
{
    public string CustomerName { get; set; } = string.Empty;
    public string Name { get; set; } = String.Empty;
    public AddressDto Address { get; set; } = new();
}