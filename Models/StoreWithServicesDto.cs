namespace Cartsy.Api.Models;

public class StoreWithServicesDto
{
    public string Name { get; set; } = string.Empty;
    public string CustomerName { get; set; }
    public List<AdditionalServiceDto> Services { get; set; } = new();
}