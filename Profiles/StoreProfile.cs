using Cartsy.Api.Entities;
using Cartsy.Api.Models;
using AutoMapper;

namespace Cartsy.Api.Profiles;

public class StoreProfile : Profile
{
    public StoreProfile()
    {
        CreateMap<Store, StoreForCreationDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)) // Example: Mapping UserId
            .ReverseMap();

        CreateMap<Store, StoreWithAddressDto>().ReverseMap();
        CreateMap<Store, StoreWithItemsDto>().ReverseMap();
        CreateMap<Store, StoreWithOrdersDto>().ReverseMap();
        CreateMap<Store, StoreWithServicesDto>().ReverseMap();
        CreateMap<Item, ItemDto>().ReverseMap();
        CreateMap<Item, ItemForOrderReturnDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<AdditionalServices, AdditionalServiceDto>().ReverseMap();
    }
}