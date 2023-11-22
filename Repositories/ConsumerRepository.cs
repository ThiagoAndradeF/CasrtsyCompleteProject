using Atividade.Api.DbContexts;
using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Atividade.Api.Repositories;

public class ConsumerRepository : IConsumerRepository
{
    private readonly CartsyContext _context;
    private readonly IMapper _mapper;

    public ConsumerRepository(CartsyContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;

    }
    
////////////////////////////////////////////////////////////////////////////
// Consumers
////////////////////////////////////////////////////////////////////////////
    ///////////////////////////
    // Create
    public async Task<bool> AddConsumer(Consumer consumer)
    {
        await _context.Consumers.AddAsync(consumer);
        return await SaveChangesAsync();
    }

    ///////////////////////////
    // Read
    public async Task<bool> AddConsumerAsync(ConsumerWithAdressDto consumer)
    {
        await _context.Consumers.AddAsync(_mapper.Map<Consumer>(consumer));
        return await SaveChangesAsync();
    }

    public async Task<ConsumerWithAdressDto?> GetConsumerByIdAsync(int consumerId)
    {
        return _mapper.Map<ConsumerWithAdressDto>(await _context.Consumers.Include(nc => nc.Address).FirstOrDefaultAsync(c => c.Id == consumerId));
    }

    public async Task<Consumer?> GetConsumerWithAdressByIdAsync(int consumerId)
    {
        return await _context.Consumers
            .Include(c => c.Address)
            .FirstOrDefaultAsync(c => c.Id == consumerId);
    }

    public async Task<IEnumerable<Consumer>> GetConsumersAsync()
    {
        return await _context.Consumers.OrderBy(c => c.Id).ToListAsync();
    }

    public async Task<bool> DeactivateConsumerAsync(int consumerId)
    {
        var consumerFromDb = await _context.Consumers.FirstOrDefaultAsync(c => c.Id == consumerId);
        consumerFromDb!.Status = false;
        await SaveChangesAsync();
        return true;
    }

    public async Task<bool> ConsumerExistsAsync(int consumerId)
    {
        return await _context.Consumers.AnyAsync(c => c.Id == consumerId);
    }
    

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }



}
