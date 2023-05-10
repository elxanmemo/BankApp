using bank.DAL.Abstract;
using bank.DAL.DataContext;
using bank.Entities;

namespace bank.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDataContext  _context;
        public UserRepository(MyDataContext context)
        {
            _context=context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
