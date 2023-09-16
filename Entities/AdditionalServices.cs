namespace Cartsy.Api.Entities;

public class AdditionalServices
{
    public int Id { get; set; }
    public string Service = string.Empty;
    public double Price { get; set; }
    public string Type { get; set; }

    public List<Store> Stores {get; set;} = new();

}