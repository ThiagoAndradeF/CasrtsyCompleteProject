namespace Atividade.Api.Models;

public class AdditionalServiceDto
{
    public string Service { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Type { get; set; } = default!;
    public int Id {  get; set; }
}