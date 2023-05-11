using bank.DTOs.BankDto;
using bank.DTOs.UserDto;

namespace bank.BLL.Abstract
{
    public interface IBankService
    {
        void Add(BankToAddDto dto);

    }
}
