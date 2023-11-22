using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;

namespace Atividade.Api.Profiles;

public class ConsumerProfile : Profile
{
    public ConsumerProfile()
    {
        CreateMap<Consumer, ConsumerWithAdressAndPhoneDto>().ReverseMap();
    }
}