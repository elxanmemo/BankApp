using AutoMapper;
using bank.DTOs.BankDto;
using bank.DTOs.CardDto;
using bank.DTOs.OrderDto;
using bank.DTOs.RegisterDto;
using bank.DTOs.UserDto;
using bank.Entities;

namespace bank.BLL.Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<UserToAddDto, User>();
           CreateMap<OrderToAddDto, Order>();
            CreateMap<BankToAddDto, Bank>();
            CreateMap<Card, CardToListDto>();
            

        }



    }
}
