using AutoMapper;
using bank.BLL.Abstract;
using bank.DAL.Abstract;
using bank.DTOs.BankDto;
using bank.DTOs.CardDto;
using bank.Entities;

namespace bank.BLL.Concrete
{
    public class CardService:ICardService
    {
        private readonly IMapper _mapper;
        private readonly ICardRepository _repository;
        public CardService(IMapper mapper, ICardRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Add(CardToAddDto dto)
        {
            Card card = _mapper.Map<Card>(dto);
            _repository.Add(card);

        }
    }
}
