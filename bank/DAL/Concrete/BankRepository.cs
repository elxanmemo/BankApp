using bank.DAL.Abstract;
using bank.DAL.DataContext;
using bank.Entities;

namespace bank.DAL.Concrete
{
    public class BankRepository:IBankRepository
    {
        private readonly MyDataContext _context;
        public BankRepository(MyDataContext context)
        {
            _context = context;
        }

        public void Add(Bank bank)
        {
            _context.Banks.Add(bank);
            _context.SaveChanges();
        }
    }
}

