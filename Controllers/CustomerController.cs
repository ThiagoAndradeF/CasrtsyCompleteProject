using Atividade.Api.Models;
using Atividade.Api.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Atividade.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{

    private readonly ICustomerRepository _repository;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<CustomerWithAdressDto>> CreateCustomer(CustomerWithAdressDto customer, string type)
    {
        if (customer.CPF!= null && customer.CNPJ != null || (customer.CPF == null && customer.CNPJ == null))
        {
            return BadRequest();
        }
        
        if (type.ToLower() == "legal" && customer.CNPJ!=null)
        {
            await _repository.AddCustomerAsync(customer, 1);
        }

        if (type.ToLower() == "natural" && customer.CPF!=null)
        {
            await _repository.AddCustomerAsync(customer, 2);
        }

        return Ok(customer);
    }
    
    
    [HttpGet("{customerId}")]
    public async Task<ActionResult<CustomerDto>> GetCustomerById([FromRoute] int customerId)
    {
        var customerFromDb = await _repository.GetCustomerByIdAsync(customerId);

        if (customerFromDb == null)
        {
            return NotFound();
        }
        return Ok(customerFromDb);
    }
    [HttpGet("teste")]
    public string GetCustomerById()
    {
        return "sapoDeBorracha";
    }
    [HttpGet("withAddress/{customerId}")]
    public async Task<ActionResult<CustomerWithAdressDto>> GetCustomerWithAddressById([FromRoute] int customerId)
    {

        var customerFromDb = await _repository.GetCustomerWithAddressByIdAsync(customerId);

        if (customerFromDb == null)
        {
            return NotFound();
        }
        return Ok(customerFromDb);
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAllCustomers()
    {
        return Ok(await _repository.GetCustomersAsync());
    }
    
    [HttpGet("active")]
    public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAllActiveCustomers()
    {
        return Ok(await _repository.GetActiveCustomersAsync());
    }

    [HttpPut("deactivate/{customerId}")]
    public async Task<ActionResult<bool>> DeactivateCutomerById(int customerId)
    {
        if (customerId==0)
        {
            return BadRequest();
        }
        return Ok(await _repository.DeactivateCustomerAsync(customerId));
    }
    
}
    

