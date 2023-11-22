using Atividade.Api.DbContexts;
using Atividade.Api.Entities;

namespace Atividade.Api.Repositories;

public class AddressRepository : IAddressRepository
{
    private readonly CartsyContext _context;

    public AddressRepository(CartsyContext context)
    {
        _context = context;
    }


    public Task<bool> AddAddressAsync(Address adress, string cityName, string stateName, string uf)
    {
        return Task.FromResult(true);
    }

    public Task<Customer?> GetAddressByIdAsync(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeactivateCustomerAsync(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CustomerExistsAsync(int customerId)
    {
        throw new NotImplementedException();
    }
}
