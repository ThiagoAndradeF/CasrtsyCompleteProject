using Atividade.Api.Models;

namespace Atividade.Api.Repositories;

public interface IStoreRepository
{

    Task<bool> AddStoreAsync(StoreForCreationDto store);
    Task<bool> AddCompleteStoreAsync(StoreForCompleteCreationDto store);
    Task<StoreWithServicesDto?> GetStoreWithServicesByIdAsync(int storeId);
    Task<StoreWithAddressDto?> GetStoreWithAddressByIdAsync(int storeId);
    Task<StoreWithOrdersDto?> GetStoreWithOrdersByIdAsync(int storeId);
    Task<StoreWithItemsDto?> GetStoreWithItemsByIdAsync(int storeId);
    Task<StoreWithItemsDto?> GetStoreWithItemsByMailAsync(string storeMail); 
    Task<bool> AddItemToStoreById(int storeId, ItemDto item);
    Task<bool> UpdateItem(int storeId,int itemId, ItemDto item);
    Task<bool> DeleteItem(int storeId, int itemId);
    Task<bool> AddOrderToStoreById(int storeId, OrderDto order);
    Task<bool> AddServicesToStoreById(int storeId, List<AdditionalServiceDto> services);
    Task<bool> SaveChangesAsync();
}