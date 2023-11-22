namespace Atividade.Api.Models;

public class OrderFullDto
{
    public int Id { get; set; }
    public double Price { get; set;}
    public DateTime Date { get; set; }
    public StatusDto Status { get; set; } = default!;
    public List<ItemForOrderReturnDto> Items { get; set; } = default!;
    public ConsumerWithAdressAndPhoneDto Consumer { get; set; } = default!;

}