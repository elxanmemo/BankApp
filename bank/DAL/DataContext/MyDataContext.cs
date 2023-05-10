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
    }
}
