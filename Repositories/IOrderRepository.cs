using Cartsy.Api.Models;

namespace Cartsy.Api.Repositories;

public interface IOrderRepository 
{
    Task<bool> AddItemsToOrderById(int orderId, List<ItemDto> items);
    Task<IEnumerable<OrderFullDto>> GetAllOrdersByStoreId(int storeId);
    Task<bool> SaveChangesAsync();

}