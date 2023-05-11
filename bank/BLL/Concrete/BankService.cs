using AutoMapper;
using bank.BLL.Abstract;
using bank.DAL.Abstract;
using bank.DTOs.BankDto;
using bank.DTOs.UserDto;
using bank.Entities;

namespace bank.BLL.Concrete
{
    public class BankService:IBankService
    {
        private readonly IMapper _mapper;
        private readonly IBankRepository _repository;
        public BankService(IMapper mapper, IBankRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Add(BankToAddDto dto)
        {
            Bank bank = _mapper.Map<Bank>(dto);
            _repository.Add(bank);

        }
    }
}
