namespace Atividade.Api.Models;

public class StoreForCreationDto
{

    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public AddressDto? Address { get; set; }
}