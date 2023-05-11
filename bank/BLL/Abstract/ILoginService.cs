using bank.DTOs.RegisterDto;
using bank.DTOs.UserDto;

namespace bank.BLL.Abstract
{
    public interface ILoginService
    {
        public bool  Get(LoginToGetDto dto);
    }
}
