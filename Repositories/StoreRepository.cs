using AutoMapper;
using Cartsy.Api.DbContexts;
using Cartsy.Api.Entities;
using Cartsy.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cartsy.Api.Repositories;

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
        await  _context.Stores.AddAsync(_mapper.Map<Store>(store));
        return await SaveChangesAsync();
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
    public async Task<bool> AddItemToStoreById(int storeId, ItemDto item)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Items.Add(_mapper.Map<Item>(item));
        return await SaveChangesAsync();
    }

    public async Task<bool> AddOrderToStoreById(int storeId, OrderDto order)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Orders.Add(_mapper.Map<Order>(order));
        return await SaveChangesAsync();
    }

    public async Task<bool> AddServicesToStoreById(int storeId, List<AdditionalServiceDto> services)
    {
        var storeFromDb = await _context.Stores.FirstOrDefaultAsync(s => s.Id == storeId);
        if (storeFromDb == null) return false;
        storeFromDb.Services.AddRange(_mapper.Map<List<AdditionalServices>>(services));
        return await SaveChangesAsync();
    }

    
    
    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}