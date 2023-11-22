namespace Atividade.Api.Entities;

public abstract class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; }  = string.Empty;
    public string HomePhone { get; set;}  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int TypeDiscriminator { get; set; }
    public bool Status { get; set; }
    public int? AddressId { get; set; }
    public Address? Address { get; set; }
}