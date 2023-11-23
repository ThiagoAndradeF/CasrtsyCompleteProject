namespace Atividade.Api.Models;

public class ItemCreateDto
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set;}
    public string? Description { get; set; } = string.Empty;
    public int? Stock { get; set; }
    public TypeDto Type { get; set; } = default!;
}