using AutoMapper;
using bank.BLL.Abstract;
using bank.DAL.Abstract;
using bank.DTOs.BankDto;
using bank.DTOs.OrderDto;
using bank.Entities;

namespace bank.BLL.Concrete
{
    public class OrderService:IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _repository;
        public OrderService(IMapper mapper, IOrderRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Add(OrderToAddDto dto)
        {
            Order order = _mapper.Map<Order>(dto);
            _repository.Add(order);

        }
    }
}
