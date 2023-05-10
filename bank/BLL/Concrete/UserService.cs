using AutoMapper;
using bank.BLL.Abstract;
using bank.DAL.Abstract;
using bank.DAL.Concrete;
using bank.DTOs.UserDto;
using bank.Entities;

namespace bank.BLL.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;
        public UserService(IMapper mapper,IUserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Add(UserToAddDto dto)
        {
           User user = _mapper.Map<User>(dto); 
            _repository.Add(user);

        }
    }
}
