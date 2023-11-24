using Atividade.Api.DbContexts;
using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Atividade.Api.Repositories;

public class StoreRepository : IStoreRepository
{

    private readonly CartsyContext _context;
    private readonly IMapper _mapper;

    public StoreRepository(CartsyContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<bool> AddStoreAsync(StoreForCreationDto store)
    {
        await _context.Stores.AddAsync(_mapper.Map<Store>(store));
        return await SaveChangesAsync();
    }

    public async Task<bool> AddCompleteStoreAsync(StoreForCompleteCreationDto store)
    {
        await _context.Stores.AddAsync(_mapper.Map<Store>(store));
        return await SaveChangesAsync();
    }

    public async Task<bool> LoginStore(string email, string password)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Email == email);

        if (storeFromDb == null) return false;

        if (storeFromDb.Password == password) return true;

        return false;
    }

    public async Task<StoreWithServicesDto?> GetStoreWithServicesByIdAsync(int storeId)
    {
        return _mapper.Map<StoreWithServicesDto>(
            await _context.Stores
                .Include(s => s.Services)
                .FirstOrDefaultAsync(s => s.Id == storeId));
    }

    public async Task<StoreWithAddressDto?> GetStoreWithAddressByIdAsync(int storeId)
    {
        return _mapper.Map<StoreWithAddressDto>(
            await _context.Stores
                .Include(s => s.Address)
                .FirstOrDefaultAsync(s => s.Id == storeId));
    }

    public async Task<StoreWithOrdersDto?> GetStoreWithOrdersByIdAsync(int storeId)
    {
        return _mapper.Map<StoreWithOrdersDto>(
            await _context.Stores
                .Include(s => s.Orders)
                .FirstOrDefaultAsync(s => s.Id == storeId));
    }

    public async Task<StoreWithItemsDto?> GetStoreWithItemsByIdAsync(int storeId)
    {
        return _mapper.Map<StoreWithItemsDto>(
            await _context.Stores
                .Include(s => s.Items)
                .FirstOrDefaultAsync(s => s.Id == storeId));
    }
    public async Task<StoreWithItemsDto?> GetStoreWithItemsByMailAsync(string storeMail)
    {
        return _mapper.Map<StoreWithItemsDto>(
            await _context.Stores
                .Include(s => s.Items)
                .FirstOrDefaultAsync(s => s.Email == storeMail));
    }
    public async Task<bool> AddItemToStoreById(int storeId, ItemCreateDto item)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Items.Add(_mapper.Map<Item>(item));
        return await SaveChangesAsync();
    }

    public async Task<bool> UpdateItem(int storeId, int itemId, ItemDto item)
    {
        var itemFromDb = await _context.Items.FirstOrDefaultAsync(
            i => i.StoreId == storeId &&
                 i.Id == itemId);

        if (itemFromDb == null)
        {
            return false;
        }

        itemFromDb = _mapper.Map<Item>(item);

        return await SaveChangesAsync();
    }

    public async Task<bool> DeleteItem(int storeId, int itemId)
    {
        var itemFromDb = await _context.Items.FirstOrDefaultAsync(i => i.Id == itemId && i.StoreId == storeId);
        if (itemFromDb == null) return false;
        _context.Items.Remove(itemFromDb);
        return await SaveChangesAsync();
    }

    public async Task<bool> AddOrderToStoreById(int storeId, OrderDto order)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Orders.Add(_mapper.Map<Order>(order));
        return await SaveChangesAsync();
    }

    public async Task<bool> AddServiceToStoreById(int storeId, AdditionalServiceDto service)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Services.Add(_mapper.Map<AdditionalServices>(service));
        return await SaveChangesAsync();
    }

    public async Task<bool> RemoveAdditionalServiceById(int serviceId)
    {
        var serviceFromDb = await _context.AdditionalServices.FirstOrDefaultAsync(s => s.Id == serviceId);
        if (serviceFromDb == null) return false;
        _context.AdditionalServices.Remove(serviceFromDb);
        return await SaveChangesAsync();
    }

    public async Task<bool> UpdateAdditionalServiceById(int serviceId, AdditionalServiceDto additionalService)
    {
        var serviceFromDb = await _context.AdditionalServices.FirstOrDefaultAsync(s => s.Id == serviceId);
        if (serviceFromDb == null) return false;
        serviceFromDb.Price = additionalService.Price;
        serviceFromDb.Type = additionalService.Type;
        serviceFromDb.Service = additionalService.Service;
        return await SaveChangesAsync();
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    private void SaveFileLocally(byte[] file, string filename)
    {
        File.WriteAllBytes(AppContext.BaseDirectory + Path.DirectorySeparatorChar + filename , file);
    }

    public async Task<byte[]> GetFile(string filename)
    {
        return await File.ReadAllBytesAsync(AppContext.BaseDirectory + Path.DirectorySeparatorChar + filename);
    }
}