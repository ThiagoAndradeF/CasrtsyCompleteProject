namespace Atividade.Api.Models;

public class ConsumerWithAdressAndPhoneDto
{
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public AddressDto Address { get; set; } = default!;
}