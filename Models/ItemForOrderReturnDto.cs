namespace Cartsy.Api.Models;

public class ItemForOrderReturnDto
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set;}
    public string Description { get; set; } = string.Empty;
    public TypeDto Type { get; set; }
}