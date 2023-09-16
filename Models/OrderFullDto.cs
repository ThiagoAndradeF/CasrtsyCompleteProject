namespace Cartsy.Api.Models;

public class OrderFullDto
{
    public int Id { get; set; }
    public double Price { get; set;}
    public DateTime Date { get; set; }
    public StatusDto Status { get; set; }
    public List<ItemForOrderReturnDto> Items { get; set; }
    public ConsumerWithAdressAndPhoneDto Consumer { get; set; }

}