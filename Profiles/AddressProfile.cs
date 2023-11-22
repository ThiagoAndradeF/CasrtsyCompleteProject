using Atividade.Api.Entities;
using AutoMapper;

namespace Atividade.Api.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, Models.AddressDto>();
    }

}