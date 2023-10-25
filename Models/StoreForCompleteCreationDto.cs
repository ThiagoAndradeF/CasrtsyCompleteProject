namespace Cartsy.Api.Models;

public class StoreForCompleteCreationDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public AddressDto? Address { get; set; }
    public List<ItemDto>? Items { get; set; } = new();
    public List<AdditionalServiceDto> Services { get; set; } = new();
}