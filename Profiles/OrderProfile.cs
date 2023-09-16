using AutoMapper;
using Cartsy.Api.Entities;
using Cartsy.Api.Models;

namespace Cartsy.Api.Profiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderFullDto>().ReverseMap();
        CreateMap<OrderStatus, StatusDto>().ReverseMap();
    }
}