using bank.Entities;
using Microsoft.EntityFrameworkCore;

namespace bank.DAL.DataContext
{
    public class MyDataContext:DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options):base(options)
        {
            
        }
     public   DbSet<User> Users { get; set; } 
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
