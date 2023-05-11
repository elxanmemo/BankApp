using bank.DAL.Abstract;
using bank.DAL.DataContext;
using bank.Entities;

namespace bank.DAL.Concrete
{
    public class CardRepository:ICardRepository
    {
        private readonly MyDataContext _context;
        public CardRepository(MyDataContext context)
        {
            _context = context;
        }

        public void Add(Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
        }
    }
}
