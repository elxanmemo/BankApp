using bank.DAL.Abstract;
using bank.DAL.DataContext;
using bank.Entities;

namespace bank.DAL.Concrete
{
    public class OrderRepository:IOrderRepository
    {
        private readonly MyDataContext _context;
        public OrderRepository(MyDataContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }

}

