namespace Atividade.Api.Entities;

public class Address
{
    public int Id { get; set; }
    public string Street = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public int Number { get; set; }
    public string City { get; set; } = String.Empty;    
    public string State { get; set; } = String.Empty;
    public string UF { get; set; } = String.Empty;
    public Customer? Customer { get; set; }
    public Store? Store { get; set; }


}