namespace Cartsy.Api.Models;

public class CustomerDto
{
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string? CPF { get; set; }
    public string? CNPJ { get; set; }
    public bool Status { get; set; }
}