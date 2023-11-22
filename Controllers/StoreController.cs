using Atividade.Api.Models;
using Atividade.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Atividade.Api.Controllers;

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
    
    
    [HttpPost("/complete")]
    public async Task<ActionResult<StoreForCreationDto>> AddCompleteStoreAsync(
        [FromBody] StoreForCompleteCreationDto store
    )
    {
        await _repository.AddCompleteStoreAsync(store);
        return Ok(store);
    }

    [HttpPost("/{storeId}/product")]
    public async Task<ActionResult<bool>> AddProductToStoreById(int storeId, [FromBody]ItemDto item)
    {
        var response = await _repository.AddItemToStoreById(storeId, item);
        if (response) return Ok();
        return BadRequest();
    }

    [HttpPut("/{storeId}/products/{itemId}")]
    public async Task<ActionResult> UpdateItem(int storeId, int itemId, ItemDto item)
    {
        if (itemId != item.id) return BadRequest();

        if (await _repository.UpdateItem(storeId, itemId, item)) return Ok();
        
        return NotFound();
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

    [HttpGet("WithItemsByMail/{storeMail}")]
    public async Task<ActionResult<StoreWithItemsDto>> GetStoreWithMail(string storeMail)
    {
        var storeFromDb = await _repository.GetStoreWithItemsByMailAsync(storeMail);

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
    
    [HttpPost("upload")]
    public async Task<IActionResult> Post(List<IFormFile> myfile)
    {
        var uploads = Path.Combine("C:\\Users\\Thiago\\Desktop\\cartsy\\CasrtsyCompleteProject\\ClientApp\\src\\assets\\products");
        foreach (var file in myfile)
        {
            if (file.Length > 0)
            {
                var filePath = Path.Combine(uploads, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
        }
        return Ok(new { myfile.Count });
    }

    // [HttpPost("JoinTeamsAndStudent")]
    // public async Task<ActionResult<StudentTeam>> AssociateTeamStudent(int teamId, int studentId)
    // {
    //     var studentTeamEntity = await _repository.JoinTeamAndStudent(studentId, teamId);
    //     return Ok(studentTeamEntity);
    // }
}
