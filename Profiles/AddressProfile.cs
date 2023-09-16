using AutoMapper;
using Cartsy.Api.Entities;

namespace Cartsy.Api.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, Models.AddressDto>();
    }

}