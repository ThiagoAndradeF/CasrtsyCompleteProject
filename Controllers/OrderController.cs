using Atividade.Api.Models;
using Atividade.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Atividade.Api.Controllers;
[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderRepository _orderRepository;

    public OrderController(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    [HttpPost]
    public async Task<ActionResult<bool>> CreateCompleteOrderAsync(OrderDto order)
    {
        var result = await _orderRepository.CreateOrderWithItemsAndServicesAsync(order);
        
        if(result) return Ok(order);
        return BadRequest(order);
    }

    [HttpGet("{storeId}")]
    public async Task<ActionResult<IEnumerable<OrderDto>>> GetAllOrders(int storeId)
    {
        return Ok(await _orderRepository.GetAllOrdersByStoreId(storeId));
    }
}