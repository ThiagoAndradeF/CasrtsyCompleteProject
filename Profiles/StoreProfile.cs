using Atividade.Api.Entities;
using Atividade.Api.Models;
using AutoMapper;

namespace Atividade.Api.Profiles;

public class StoreProfile : Profile
{
    public StoreProfile()
    {
        CreateMap<Store, StoreForCreationDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)) // Example: Mapping UserId
            .ReverseMap();
        CreateMap<Store, StoreForCompleteCreationDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
            .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.Services))
            .ReverseMap();
        CreateMap<Store, StoreWithAddressDto>().ReverseMap();
        CreateMap<Store, StoreWithItemsDto>().ReverseMap();
        CreateMap<Store, StoreWithOrdersDto>().ReverseMap();
        CreateMap<Store, StoreWithServicesDto>().ReverseMap();
        CreateMap<Item, ItemDto>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type)).ReverseMap();
        CreateMap<ItemType, TypeDto>().ReverseMap();
        CreateMap<Item, ItemForOrderReturnDto>().ReverseMap();
        CreateMap<Item, ItemCreateDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<AdditionalServices, AdditionalServiceDto>().ReverseMap();
    }
}