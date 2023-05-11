using bank.DAL.Abstract;
using bank.DAL.DataContext;
using bank.DTOs.RegisterDto;
using bank.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;

namespace bank.DAL.Concrete
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MyDataContext  _context;
        public LoginRepository(MyDataContext context)
        {
            _context=context;
        }

        public bool Get(LoginToGetDto dto)
        {
            var user =  _context.Users.FirstOrDefault(u =>u.UserName==dto.UserName);
            if (user==null)
            {
                return false;

            }
            if (user.Password==dto.Password)
            {
                return true;
            }
           else return false;
        } 
    }
}
