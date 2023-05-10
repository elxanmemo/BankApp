using bank.Entities;
using Microsoft.EntityFrameworkCore;

namespace bank.DAL.DataContext
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            //test
            //test2
            //test3
        }
        DbSet<User> Users { get; set; } 
    }
}
