using AutoMapper;
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
           CreateMap<User, LoginToGetDto>();

        }



    }
}
