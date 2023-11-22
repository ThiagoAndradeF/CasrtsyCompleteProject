using Atividade.Api.Entities;
using Atividade.Api.Models;

namespace Atividade.Api.Repositories;

public interface ICustomerRepository
{
Task<bool> AddCustomerAsync(CustomerWithAdressDto customer, int type);
Task<CustomerDto?> GetCustomerByIdAsync(int customerId);
Customer GetCustomerById(int customerId);

Task<CustomerWithAdressDto?> GetCustomerWithAddressByIdAsync(int customerId);


Task<CustomerDto?> GetLegalCustomerByIdAsync(int customerId);
Task<CustomerDto?> GetNaturalCustomerByIdAsync(int customerId);

Task<CustomerWithAdressDto?> GetLegalCustomerWithAdressByIdAsync(int customerId);
Task<CustomerWithAdressDto?> GetNaturalCustomerWithAdressByIdAsync(int customerId);

Task<IEnumerable<CustomerDto>> GetCustomersAsync();
Task<IEnumerable<CustomerDto>> GetActiveCustomersAsync();

Task<bool> DeactivateCustomerAsync(int customerId);
Task<bool> CustomerExistsAsync(int customerId);
Task<int> GetCustomerTypeAsync(int customerId);

}