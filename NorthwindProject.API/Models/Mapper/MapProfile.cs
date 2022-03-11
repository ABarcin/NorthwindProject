using AutoMapper;
using NorthwindProject.API.Models.DB.Entities;
using NorthwindProject.API.Models.DTOS;

namespace NorthwindProject.API.Models.Mapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<OrderDetailDTO, OrderDetail>();
        }
    }
}
