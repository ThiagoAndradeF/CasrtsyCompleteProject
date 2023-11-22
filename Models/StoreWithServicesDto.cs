namespace Atividade.Api.Models;

public class StoreWithServicesDto
{
    public string Name { get; set; } = string.Empty;
    public string CustomerName { get; set; }  = default!;
    public List<AdditionalServiceDto> Services { get; set; } = default!;
}