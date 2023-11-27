namespace Atividade.Api.Entities;

public class AdditionalServices
{
    public int Id { get; set; }
    public string Service = string.Empty;
    public double Price { get; set; }
    public string Type { get; set; } = default!;

    public List<Store> Stores {get; set;} = default!;
    public List<Order> Orders {get; set;} = default!;


}