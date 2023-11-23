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
    Task<bool> AddItemToStoreById(int storeId, ItemCreateDto item);
    Task<bool> UpdateItem(int storeId, int itemId, ItemDto item);
    Task<bool> DeleteItem(int storeId, int itemId);
    Task<bool> AddOrderToStoreById(int storeId, OrderDto order);
    Task<bool> AddServiceToStoreById(int storeId, AdditionalServiceDto service);
    Task<bool> RemoveAdditionalServiceById(int serviceId);

    Task<bool> UpdateAdditionalServiceById(int serviceId, AdditionalServiceDto additionalService);
    Task<bool> SaveChangesAsync();
}