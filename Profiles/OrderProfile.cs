using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;

namespace Atividade.Api.Profiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderFullDto>().ReverseMap();
        CreateMap<OrderStatus, StatusDto>().ReverseMap();
    }
}