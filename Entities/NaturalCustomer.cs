// TPT
namespace Atividade.Api.Entities;

public class NaturalCustomer : Customer
{
    public string Type { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;
}