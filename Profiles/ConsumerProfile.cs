using AutoMapper;
using Cartsy.Api.Entities;
using Cartsy.Api.Models;

namespace Cartsy.Api.Profiles;

public class ConsumerProfile : Profile
{
    public ConsumerProfile()
    {
        CreateMap<Consumer, ConsumerWithAdressAndPhoneDto>().ReverseMap();
    }
}