using AutoMapper;
using bank.BLL.Abstract;
using bank.DAL.Abstract;
using bank.DAL.Concrete;
using bank.DTOs.RegisterDto;
using bank.DTOs.UserDto;
using bank.Entities;

namespace bank.BLL.Concrete
{
    public class LoginService : ILoginService
    {
        private readonly IMapper _mapper;
       private readonly ILoginRepository _repository;

        public LoginService(ILoginRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public bool Get(LoginToGetDto dto)
        {
          
          
             
            return _repository.Get(dto);


        }

       
    }
}
