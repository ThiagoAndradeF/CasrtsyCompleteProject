using Atividade.Api.Models;
using Atividade.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCaching;

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

    [HttpPost("/complete")]
    public async Task<ActionResult<StoreForCreationDto>> AddCompleteStoreAsync(
        [FromBody] StoreForCompleteCreationDto store
    )
    {
        await _repository.AddCompleteStoreAsync(store);
        return Ok(store);
    }

    [HttpPost("/{storeId}/product")]
    public async Task<ActionResult<bool>> AddProductToStoreById(int storeId, [FromBody] ItemCreateDto item)
    {
        var response = await _repository.AddItemToStoreById(storeId, item);
        if (response) return Ok(item);
        return BadRequest(item);
    }

    [HttpPut("/{storeId}/product/{itemId}")]
    public async Task<ActionResult> UpdateItem(int storeId, int itemId, ItemDto item)
    {
        if (itemId != item.id) return BadRequest();

        if (await _repository.UpdateItem(storeId, itemId, item)) return Ok();

        return NotFound();
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



    [HttpDelete("{storeId}/product/{itemId}")]
    public async Task<ActionResult> DeleteProduct(int storeId, int itemId)
    {
        if (await _repository.DeleteItem(storeId, itemId)) return Ok();
        return NotFound();
    }

    [HttpGet("WithServices/{storeId}")]
    public async Task<ActionResult<StoreWithServicesDto>> GetStoreWithServicesByIdAsync(int storeId)
    {
        var storeFromDb = await _repository.GetStoreWithServicesByIdAsync(storeId);

        if (storeFromDb == null)
        {
            return NotFound(storeId);
        }

        return Ok(storeFromDb);
    }

    [HttpPost("/{storeId}/service")]
    public async Task<ActionResult> AddServiceToStoreById(int storeId, AdditionalServiceDto additionalService)
    {
        var response = await _repository.AddServiceToStoreById(storeId, additionalService);
        if (response) return Ok(additionalService);
        return BadRequest(additionalService);
    }

    [HttpDelete("/service/{serviceId}")]
    public async Task<ActionResult> DeleteAdditionalServiceById(int serviceId)
    {
        var response = await _repository.RemoveAdditionalServiceById(serviceId);
        if (response) return Ok(serviceId);
        return NotFound(serviceId);
    }

    [HttpPut("/service/{serviceId}")]
    public async Task<ActionResult> UpdateAdditionalService(int serviceId, AdditionalServiceDto additionalService)
    {
        var response = await _repository.UpdateAdditionalServiceById(serviceId, additionalService);
        if (response) return Ok(additionalService);
        return BadRequest(additionalService);
    }

    [HttpPost("UploadFile")]
    public IActionResult UploadFile(IFormFile formFile)
    {
        try
        {
            var memStr = new MemoryStream();
            formFile.CopyTo(memStr);
            _repository.UploadFile(memStr.ToArray(), formFile.FileName);
            Console.WriteLine("UploadFile" + formFile.FileName);
            return Ok("O arquivo foi enviado");
        }
        catch(Exception ex)
        {
            return BadRequest("Ocorreu um erro: " + ex.Message);
            Console.WriteLine(ex.Message)
        }
    }

    [HttpGet("file/{filename}")]
    public async Task<IActionResult<byte[]>> UploadFile([FromRoute]string filename)
    {
        var response = await _repository.GetFile(filename);
        return Ok(response);
    }
}