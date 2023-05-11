using bank.DTOs.CardDto;
using bank.DTOs.UserDto;

namespace bank.BLL.Abstract
{
    public interface ICardService
    {
        void Add(CardToAddDto dto);

    }
}
