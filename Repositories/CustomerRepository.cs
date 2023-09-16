using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Cartsy.Api.DbContexts;
using Cartsy.Api.Entities;
using Cartsy.Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cartsy.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly CartsyContext _context;
    private readonly IMapper _mapper;

    public CustomerRepository(CartsyContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
////////////////////////////////////////////////////////////////////////////
// Customers
////////////////////////////////////////////////////////////////////////////
    ///////////////////////////
    // Create
    public async Task<bool> AddCustomerAsync(CustomerWithAdressDto customer, int type)
    {
        if (type == 1)
        {
            await _context.Customers.AddAsync(_mapper.Map<LegalCustomer>(customer));
        }

        if (type == 2)
        {
            await _context.Customers.AddAsync(_mapper.Map<NaturalCustomer>(customer));
        }

        return await SaveChangesAsync();
    }

    ///////////////////////////
    // Read

    public async Task<CustomerDto?> GetCustomerByIdAsync(int customerId)
    {
        var type = GetCustomerTypeAsync(customerId);

        if (type.Result == 1)
        {
            return GetLegalCustomerByIdAsync(customerId).Result;
        }

        if (type.Result == 2)
        {
            return GetNaturalCustomerByIdAsync(customerId).Result;
        }

        return null;
    }
    
    public Customer GetCustomerById(int customerId)
    {
        var type = GetCustomerTypeAsync(customerId);

        if (type.Result == 1)
        {
            return _context.LegalCustomers.FirstOrDefault(c => c.Id==customerId);
        }

        if (type.Result == 2)
        {
            return _context.NaturalCustomers.FirstOrDefault(c => c.Id==customerId);
        }

        return null;
    }

    public async Task<CustomerWithAdressDto?> GetCustomerWithAddressByIdAsync(int customerId)
    {
        var type = GetCustomerTypeAsync(customerId);

        if (type.Result == 1)
        {
            return GetLegalCustomerWithAdressByIdAsync(customerId).Result;
        }

        if (type.Result == 2)
        {
            return GetNaturalCustomerWithAdressByIdAsync(customerId).Result;
        }

        return null;
    }

    
    public async Task<CustomerDto?> GetNaturalCustomerByIdAsync(int customerId)
    {
        return _mapper.Map<CustomerDto>(await _context.NaturalCustomers.Include(nc => nc.Address).FirstOrDefaultAsync(c => c.Id == customerId));
    }
    public async Task<CustomerDto?> GetLegalCustomerByIdAsync(int customerId)
    {
        return _mapper.Map<CustomerDto>(await _context.LegalCustomers.Include(lc => lc.Address).FirstOrDefaultAsync(c => c.Id == customerId));
    }

    public async Task<CustomerWithAdressDto?> GetLegalCustomerWithAdressByIdAsync(int customerId)
    {
        return _mapper.Map<CustomerWithAdressDto>(await _context.LegalCustomers.Include(lc => lc.Address).FirstOrDefaultAsync(c => c.Id == customerId));
    }
    public async Task<CustomerWithAdressDto?> GetNaturalCustomerWithAdressByIdAsync(int customerId)
    {
        return _mapper.Map<CustomerWithAdressDto>(await _context.NaturalCustomers.Include(lc => lc.Address).FirstOrDefaultAsync(c => c.Id == customerId));
    }

    public async Task<IEnumerable<CustomerDto>> GetCustomersAsync()
    {
        return _mapper.Map<IEnumerable<CustomerDto>>(await _context.Customers.OrderBy(c => c.Id).ToListAsync());
    }
    
    public async Task<IEnumerable<CustomerDto>> GetActiveCustomersAsync()
    {
        return _mapper.Map<IEnumerable<CustomerDto>>(await _context.Customers.Where(c => c.Status == true).OrderBy(c => c.Id).ToListAsync());
    }

    public async Task<bool> DeactivateCustomerAsync(int customerId)
    {
        var customerFromDb = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
        customerFromDb.Status = false;
        SaveChangesAsync();
        return true;
    }

    public async Task<bool> CustomerExistsAsync(int customerId)
    {
        return await _context.Customers.AnyAsync(c => c.Id == customerId);
    }

    public async Task<int> GetCustomerTypeAsync(int customerId)
    {
        if (!CustomerExistsAsync(customerId).Result)
        {
            return 0;
        }
        var customerFromDb = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
        return customerFromDb.TypeDiscriminator;
    }
    

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }



}
