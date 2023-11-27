using Atividade.Api.DbContexts;
using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Atividade.Api.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly CartsyContext _context;
    private readonly IMapper _mapper;

    public OrderRepository(CartsyContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<OrderFullDto>> GetAllOrdersByStoreId(int storeId)
    {
        var orderFromDb = await _context.Orders
            .Include(o => o.Items)
            .Include(o => o.Services)
            .Where(o => o.StoreId == storeId)
            .OrderBy( o => o.Id)
            .ToListAsync();
        var value = _mapper.Map<List<OrderFullDto>>(orderFromDb);
        return  value;
    }

    public async Task<bool> CreateOrderWithItemsAndServicesAsync(OrderDto order)
    {
        var items = await _context.Items.Where(i => order.ItemIds.Contains(i.Id)).ToListAsync();
        var services = await _context.AdditionalServices.Where(s => order.ServiceIds.Contains(s.Id)).ToListAsync();
        var orderToAdd = _mapper.Map<Order>(order);
        orderToAdd.Items = items;
        orderToAdd.Services = services;
        await _context.Orders.AddAsync(orderToAdd);
        return await SaveChangesAsync();
    }

    public async Task<bool> AddItemsToOrderById(int orderId, List<ItemDto> items)
    {
        var orderFromDb = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
        if (orderFromDb == null) return false;
        orderFromDb.Items.AddRange(_mapper.Map<List<Item>>(items));
        return await SaveChangesAsync();
    }
    
    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}