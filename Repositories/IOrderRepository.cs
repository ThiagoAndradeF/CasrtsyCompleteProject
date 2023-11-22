using Atividade.Api.Models;

namespace Atividade.Api.Repositories;

public interface IOrderRepository 
{
    Task<bool> AddItemsToOrderById(int orderId, List<ItemDto> items);
    Task<IEnumerable<OrderFullDto>> GetAllOrdersByStoreId(int storeId);
    Task<bool> SaveChangesAsync();

}