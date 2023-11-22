// TPT
namespace Atividade.Api.Entities;

public class LegalCustomer : Customer
{
    public string Type { get; set; } = string.Empty;

    public string CNPJ { get; set; } = string.Empty;
}