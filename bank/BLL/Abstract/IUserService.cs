using bank.DTOs.UserDto;

namespace bank.BLL.Abstract
{
    public interface IUserService
    {
        void Add(UserToAddDto dto);
    }
}
