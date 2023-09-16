using Microsoft.AspNetCore.Mvc;
using Cartsy.Api.Entities;
using Cartsy.Api.Models;
using Cartsy.Api.Repositories;

namespace Cartsy.Api.Controllers;

[ApiController]
[Route("api/stores")]
public class StoreController : ControllerBase
{
    private readonly IStoreRepository _repository;
    private readonly IOrderRepository _orderRepository;

    public StoreController(IStoreRepository repository, IOrderRepository orderRepository)
    {
        _repository = repository;
        _orderRepository = orderRepository;
    }
    [HttpPost]
    public async Task<ActionResult<StoreForCreationDto>> AddStoreAsync(
        [FromBody] StoreForCreationDto store
    )
    {
        await _repository.AddStoreAsync(store);

        return Ok(store);
    }

    [HttpGet("WithServices/{storeId}")]
    public async Task<ActionResult<StoreWithServicesDto>> GetStoreWithServicesByIdAsync(int storeId)
    {
        var storeFromDb = await _repository.GetStoreWithServicesByIdAsync(storeId);

        if (storeFromDb == null)
        {
            return NotFound();
        }

        return Ok(storeFromDb);
    }
    
    [HttpGet("WithAddress/{storeId}")]
    public async Task<ActionResult<StoreWithAddressDto>> GetStoreWithAddressByIdAsync(int storeId)
    {
        var storeFromDb = await _repository.GetStoreWithAddressByIdAsync(storeId);

        if (storeFromDb == null)
        {
            return NotFound();
        }

        return Ok(storeFromDb);
    }
    
    [HttpGet("WithItems/{storeId}")]
    public async Task<ActionResult<StoreWithItemsDto>> GetStoreWithItemsByIdAsync(int storeId)
    {
        var storeFromDb = await _repository.GetStoreWithItemsByIdAsync(storeId);

        if (storeFromDb == null)
        {
            return NotFound();
        }

        return Ok(storeFromDb);
    }
    
    [HttpGet("WithOrders/{storeId}")]
    public async Task<ActionResult<StoreWithOrdersDto>> GetStoreWithOrdersByIdAsync(int storeId)
    {
        var storeFromDb = await _repository.GetStoreWithOrdersByIdAsync(storeId);

        if (storeFromDb == null)
        {
            return NotFound();
        }

        return Ok(storeFromDb);
    }
    
    [HttpGet("FullOrders/{storeId}")]
    public async Task<ActionResult<IEnumerable<OrderFullDto>>> GetFullOrderByStoreIdAsync(int storeId)
    {
        var ordersFromDb = await _orderRepository.GetAllOrdersByStoreId(storeId);

        if (ordersFromDb == null || !ordersFromDb.Any())
        {
            return NotFound();
        }

        return Ok(ordersFromDb);
    }
    
    // [HttpPost("JoinTeamsAndStudent")]
    // public async Task<ActionResult<StudentTeam>> AssociateTeamStudent(int teamId, int studentId)
    // {
    //     var studentTeamEntity = await _repository.JoinTeamAndStudent(studentId, teamId);
    //     return Ok(studentTeamEntity);
    // }
}
