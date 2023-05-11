using bank.DAL.DataContext;
using bank.DTOs.RegisterDto;
using bank.Entities;

namespace bank.DAL.Abstract
{
    
    public interface ILoginRepository

    {
        public bool Get(LoginToGetDto dto);
    }
}
