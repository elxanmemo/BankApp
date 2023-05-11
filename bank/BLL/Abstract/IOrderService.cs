using bank.DTOs.OrderDto;
using bank.DTOs.UserDto;

namespace bank.BLL.Abstract
{
    public interface IOrderService
    {
        void Add(OrderToAddDto dto);

    }
}
