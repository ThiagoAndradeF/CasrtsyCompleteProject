using Atividade.Api.Entities;
using Atividade.Api.Models;

namespace Atividade.Api.Repositories;

public interface IConsumerRepository
{
    Task<bool> AddConsumerAsync(ConsumerWithAdressDto consumer);

    Task<ConsumerWithAdressDto?> GetConsumerByIdAsync(int consumerId);

    Task<Consumer?> GetConsumerWithAdressByIdAsync(int consumerId);
    Task<IEnumerable<Consumer>> GetConsumersAsync();
    Task<bool> DeactivateConsumerAsync(int consumerId);
    Task<bool> ConsumerExistsAsync(int consumerId);
}