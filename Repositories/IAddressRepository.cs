using Atividade.Api.Entities;

namespace Atividade.Api.Repositories;

public interface IAddressRepository
{
    Task<bool> AddAddressAsync(Address adress, string cityName, string stateName, string uf);

    Task<Customer?> GetAddressByIdAsync(int customerId);
    Task<IEnumerable<Customer>> GetCustomersAsync();
    Task<bool> DeactivateCustomerAsync(int customerId);
    Task<bool> CustomerExistsAsync(int customerId);
}