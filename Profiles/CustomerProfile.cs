using Cartsy.Api.Entities;
using Cartsy.Api.Models;
using AutoMapper;

namespace Cartsy.Api.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<LegalCustomer, CustomerWithAdressDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)) // Example: Mapping UserId
            .ReverseMap();
        
        CreateMap<NaturalCustomer, CustomerWithAdressDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)) // Example: Mapping UserId
            .ReverseMap();
        
        CreateMap<LegalCustomer, CustomerDto>()
            .ReverseMap();
        
        CreateMap<NaturalCustomer, CustomerDto>()
            .ReverseMap();
        
        CreateMap<Address, AddressDto>().ReverseMap();
        
    }
}