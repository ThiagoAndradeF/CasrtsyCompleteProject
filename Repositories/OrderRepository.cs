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
            .Include(o => o.Status)
            .Include(o => o.Consumer)
            .ThenInclude(c => c.Address)
            .Where(o => o.StatusId == storeId)
            .OrderBy( o => o.Id)
            .ToListAsync();
        
        return _mapper.Map<List<OrderFullDto>>(orderFromDb);
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